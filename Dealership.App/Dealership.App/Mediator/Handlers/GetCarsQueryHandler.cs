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
    public class GetCarsQueryHandler : IRequestHandler<GetCarsQuery, IEnumerable<CarViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetCarsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CarViewModel>> Handle(GetCarsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Car> populatedCars = await this._unitOfWork.Cars.GetAll();
            IEnumerable<CarViewModel> carsToView = this._mapper.Map<IEnumerable<CarViewModel>>(populatedCars);

            return carsToView;
        }
    }
}
