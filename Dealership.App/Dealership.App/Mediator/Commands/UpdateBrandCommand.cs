using Dealership.App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class UpdateBrandCommand : IRequest<bool>
    {
        public BrandViewModel UpdatedBrand { get; }

        public UpdateBrandCommand(BrandViewModel updatedBrand)
        {
            this.UpdatedBrand = updatedBrand;
        }
    }
}
