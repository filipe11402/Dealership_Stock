using Dealership.App.Models.CarModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class UpdateCarModelCommand : IRequest<bool>
    {
        public UpdateCarModelViewModel UpdatedCarModel { get; }

        public UpdateCarModelCommand(UpdateCarModelViewModel updatedCarModel)
        {
            this.UpdatedCarModel = updatedCarModel;
        }
    }
}
