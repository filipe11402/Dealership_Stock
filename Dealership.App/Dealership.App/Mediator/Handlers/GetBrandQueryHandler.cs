using AutoMapper;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models.CarBrand;
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
    public class GetBrandQueryHandler : IRequestHandler<GetCarBrandQuery, CarBrand>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetBrandQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<CarBrand> Handle(GetCarBrandQuery request, CancellationToken cancellationToken)
        {
            CarBrand carbrand = await this._unitOfWork.Brands.GetById(request.CarBrandId);

            return carbrand;
        }
    }
}
