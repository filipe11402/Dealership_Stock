using AutoMapper;
using Dealership.App.Mediator.Commands;
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
    public class CreateCarBrandCommandHandler : IRequestHandler<CreateCarBrandCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWOrk;
        private readonly IMapper _mapper;

        public CreateCarBrandCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWOrk = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<bool> Handle(CreateCarBrandCommand request, CancellationToken cancellationToken)
        {
            CarBrand newbrand = _mapper.Map<CarBrand>(request.CarBrand);
            var response = await this._unitOfWOrk.Brands.Add(newbrand);

            return response;
        }
    }
}
