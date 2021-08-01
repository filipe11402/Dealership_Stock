using AutoMapper;
using Dealership.App.Mediator.Commands;
using Dealership.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class DeleteCarModelCommandHandler : IRequestHandler<DeleteCarModelCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCarModelCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteCarModelCommand request, CancellationToken cancellationToken)
        {
            var response = await this._unitOfWork.Models.Delete(request.CarModelId);

            return response;
        }
    }
}
