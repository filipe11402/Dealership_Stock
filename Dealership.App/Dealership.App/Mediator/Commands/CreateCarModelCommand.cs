using Dealership.App.Models.CarModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class CreateCarModelCommand : IRequest<bool>
    {
        public CreateCarModelViewModel NewCarModel { get; }

        public CreateCarModelCommand(CreateCarModelViewModel newCarModel)
        {
            this.NewCarModel = newCarModel;
        }
    }
}
