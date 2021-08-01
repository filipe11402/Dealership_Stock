using Dealership.App.Models.CarBrand;
using Dealership.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class CreateCarBrandCommand : IRequest<bool>
    {
        public CreateCarBrandViewModel CarBrand { get; }

        public CreateCarBrandCommand(CreateCarBrandViewModel carBrand)
        {
            this.CarBrand = carBrand;
        }
    }
}
