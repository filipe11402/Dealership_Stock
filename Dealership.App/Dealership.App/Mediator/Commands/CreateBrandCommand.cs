using Dealership.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class CreateBrandCommand : IRequest<bool>
    {
        public CarBrand Brand { get; }

        public CreateBrandCommand(CarBrand carBrand)
        {
            this.Brand = carBrand;
        }
    }
}
