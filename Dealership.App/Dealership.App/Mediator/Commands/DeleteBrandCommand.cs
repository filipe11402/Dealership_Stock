using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class DeleteBrandCommand : IRequest<bool>
    {
        public int CarBrandId { get; }

        public DeleteBrandCommand(int carBrandId)
        {
            this.CarBrandId = carBrandId;
        }
    }
}
