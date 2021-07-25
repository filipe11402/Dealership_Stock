using Dealership.App.Models.CarBrand;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class UpdateCarBrandCommand : IRequest<bool>
    {
        public CarBrandViewModel UpdatedCarBrand { get; }

        public UpdateCarBrandCommand(CarBrandViewModel updatedCarBrand)
        {
            this.UpdatedCarBrand = updatedCarBrand;
        }
    }
}
