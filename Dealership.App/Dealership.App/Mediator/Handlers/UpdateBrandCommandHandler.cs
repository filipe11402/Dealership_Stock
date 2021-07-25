using AutoMapper;
using Dealership.App.Mediator.Commands;
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
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateCarBrandCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateBrandCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public Task<bool> Handle(UpdateCarBrandCommand request, CancellationToken cancellationToken)
        {
            CarBrand updatedCarBrand = this._mapper.Map<CarBrand>(request.UpdatedCarBrand);
            var response = this._unitOfWork.Brands.Update(updatedCarBrand);

            return Task.FromResult(response);
        }
    }
}
