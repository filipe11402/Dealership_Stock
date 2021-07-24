using Dealership.App.Models;
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
        public CreateBrandViewModel Brand { get; }

        public CreateBrandCommand(CreateBrandViewModel carBrand)
        {
            this.Brand = carBrand;
        }
    }
}
