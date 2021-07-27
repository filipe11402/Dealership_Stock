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
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            string path = Path.GetFullPath("wwwroot/images");

            using (var fileStream = new FileStream(path, FileMode.Create)) 
            {
                await request.NewCar.Image.CopyToAsync(fileStream);
            }

            Car newCar = this._mapper.Map<Car>(request.NewCar);
            var response = await this._unitOfWork.Cars.Add(newCar);
            this._unitOfWork.Commit();

            return response;
        }
    }
}
