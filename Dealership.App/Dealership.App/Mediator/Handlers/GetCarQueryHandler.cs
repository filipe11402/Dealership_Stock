using AutoMapper;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.Car;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, UpdateCarViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWOrk;

        public GetCarQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWOrk = unitOfWork;
        }

        public async Task<UpdateCarViewModel> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            Car fetchedCar = await this._unitOfWOrk.Cars.GetById(request.CarId);
            if (fetchedCar == null) 
            {
                return null;
            }
            UpdateCarViewModel carToView = this._mapper.Map<UpdateCarViewModel>(fetchedCar);

            return carToView;
        }
    }
}
