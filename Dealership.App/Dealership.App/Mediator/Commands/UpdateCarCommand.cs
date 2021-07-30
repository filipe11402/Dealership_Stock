using Dealership.App.Models.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class UpdateCarCommand : IRequest<bool>
    {
        public UpdateCarViewModel UpdatedCar { get; }

        public UpdateCarCommand(UpdateCarViewModel updatedCar)
        {
            this.UpdatedCar = updatedCar;
        }
    }
}
