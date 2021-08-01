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
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            Car carToDelete = this._mapper.Map<Car>(request.CarToDelete);

            DeleteImage(carToDelete.ImageName);
            var deleteResponse = await this._unitOfWork.Cars.Delete(carToDelete.CarId);

            this._unitOfWork.Commit();

            return true;
        }

        private void DeleteImage(string imageName) 
        {
            var rootPath = Path.GetFullPath("wwwroot");
            var combinedPath = Path.Combine(rootPath, "images", imageName);
            if (File.Exists(combinedPath)) 
            {
                File.Delete(combinedPath);
            }
        }

    }
}
