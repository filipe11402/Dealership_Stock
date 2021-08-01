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
    public class CreateCarModelCommandHandler : IRequestHandler<CreateCarModelCommand, bool>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCarModelCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateCarModelCommand request, CancellationToken cancellationToken)
        {
            CarModel newCarModel = this._mapper.Map<CarModel>(request.NewCarModel);
            var response = await this._unitOfWork.Models.Add(newCarModel);

            return response;
        }
    }
}
