using AutoMapper;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarModel;
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
    public class GetCarModelQueryHandler : IRequestHandler<GetCarModelQuery, CarModel>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCarModelQueryHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<CarModel> Handle(GetCarModelQuery request, CancellationToken cancellationToken)
        {
            CarModel carModel = await this._unitOfWork.Models.GetById(request.CarModelId);

            return carModel;
        }
    }
}
