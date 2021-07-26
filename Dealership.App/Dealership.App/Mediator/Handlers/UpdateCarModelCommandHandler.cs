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
    public class UpdateCarModelCommandHandler : IRequestHandler<UpdateCarModelCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCarModelCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public Task<bool> Handle(UpdateCarModelCommand request, CancellationToken cancellationToken)
        {
            CarModel updatedCarModel = this._mapper.Map<CarModel>(request.UpdatedCarModel);
            var response =  this._unitOfWork.Models.Update(updatedCarModel);

            return Task.FromResult(response);
        }
    }
}