using Dealership.App.Models.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class DeleteCarCommand : IRequest<bool>
    {
        public CarViewModel CarToDelete { get; }

        public DeleteCarCommand(CarViewModel carToDelete)
        {
            this.CarToDelete = carToDelete;
        }
    }
}
