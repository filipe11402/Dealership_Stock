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
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCarCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public Task<bool> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            Car carToDelete = this._unitOfWork.Cars.GetById(request.CarId);
        }
    }
}
