using AutoMapper;
using Dealership.App.Mediator.Commands;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CreateCarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._hostEnvironment = hostEnvironment;
        }

        public async Task<bool> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            string wwwRootPath = Path.GetFullPath("wwwroot/images");
            string fileName = Path.GetFileNameWithoutExtension(request.NewCar.Image.FileName);
            string fileExtension = Path.GetExtension(request.NewCar.Image.FileName);
            request.NewCar.ImageName = fileName + DateTime.Now.ToString("ddMMyy") + fileExtension;
            string path = Path.Combine(wwwRootPath, request.NewCar.ImageName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await request.NewCar.Image.CopyToAsync(fileStream);
            }

            Car newCar = this._mapper.Map<Car>(request.NewCar);
            newCar.Brand = await this._unitOfWork.Brands.GetById(request.NewCar.CarBrandId);
            newCar.Model = await this._unitOfWork.Models.GetById(request.NewCar.CarModelId);
            var response = await this._unitOfWork.Cars.Add(newCar);

            return response;
        }
    }
}
