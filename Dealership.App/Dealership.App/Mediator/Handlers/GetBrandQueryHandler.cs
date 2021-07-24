using AutoMapper;
using Dealership.App.Mediator.Queries;
using Dealership.App.Models;
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
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, BrandViewModel>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetBrandQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<BrandViewModel> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            CarBrand brand = await this._unitOfWork.Brands.GetById(request.BrandId);
            BrandViewModel brandToView = this._mapper.Map<BrandViewModel>(brand);

            return brandToView;
        }
    }
}
