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
    public class GetBrandsQueryHandler : IRequestHandler<GetCarBrandsQuery, IEnumerable<CarBrandViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetBrandsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<CarBrandViewModel>> Handle(GetCarBrandsQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<CarBrand> carBrands = await this._unitOfWork.Brands.GetAll();
            IEnumerable<CarBrandViewModel> carBrandsToView = this._mapper.Map<IEnumerable<CarBrandViewModel>>(carBrands);

            return carBrandsToView;
        }
    }
}
