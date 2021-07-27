using Dealership.App.Models.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class CreateCarCommand : IRequest<bool>
    {
        public CarViewModel NewCar { get; set; }

        public CreateCarCommand(CarViewModel newCar)
        {
            this.NewCar = newCar;
        }
    }
}
