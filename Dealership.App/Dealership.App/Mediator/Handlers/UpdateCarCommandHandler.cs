using AutoMapper;
using Dealership.App.Mediator.Commands;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var rootPath = Path.GetFullPath("wwwroot/images");
            var updateCarFileName = Path.GetFileNameWithoutExtension(request.UpdatedCar.Image.FileName);
            var updatedCarFileExtension = Path.GetExtension(request.UpdatedCar.Image.FileName);

            string pathToDeleteOldImage = Path.Combine(rootPath, request.UpdatedCar.ImageName);
            DeleteOldImage(pathToDeleteOldImage);

            request.UpdatedCar.ImageName = updateCarFileName + DateTime.Now.ToString("ddMMyy") + updatedCarFileExtension;
            string pathToInsertImage = Path.Combine(rootPath, request.UpdatedCar.ImageName);

            using (var fileStream = new FileStream(pathToInsertImage, FileMode.Create)) 
            {
                await request.UpdatedCar.Image.CopyToAsync(fileStream);
            }

            Car updatedCar = this._mapper.Map<Car>(request.UpdatedCar);

            updatedCar.Brand = await this._unitOfWork.Brands.GetById(request.UpdatedCar.CarBrandId);
            updatedCar.Model = await this._unitOfWork.Models.GetById(request.UpdatedCar.CarModelId);

            var response = this._unitOfWork.Cars.Update(updatedCar);
            this._unitOfWork.Commit();

            return true;
        }

        private void DeleteOldImage(string filePathToDelete) 
        {
            if (File.Exists(filePathToDelete)) 
            {
                File.Delete(filePathToDelete);
            }
        }
    }
}
