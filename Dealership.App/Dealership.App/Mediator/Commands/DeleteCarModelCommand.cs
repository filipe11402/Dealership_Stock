using Dealership.App.Models.CarModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class DeleteCarModelCommand : IRequest<bool>
    {
        public int CarModelId { get; }

        public DeleteCarModelCommand(int carModelId)
        {
            this.CarModelId = carModelId;
        }
    }
}
