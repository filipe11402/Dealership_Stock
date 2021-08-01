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
        public CreateCarViewModel NewCar { get; set; }

        public CreateCarCommand(CreateCarViewModel newCar)
        {
            this.NewCar = newCar;
        }
    }
}
