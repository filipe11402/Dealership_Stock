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
    public class DeleteCarBrandCommandHandler : IRequestHandler<DeleteCarBrandCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCarBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteCarBrandCommand request, CancellationToken cancellationToken)
        {
            var response = await this._unitOfWork.Brands.Delete(request.CarBrandId);

            return response;
        }
    }
}
