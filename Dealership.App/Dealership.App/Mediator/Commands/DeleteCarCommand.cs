using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Commands
{
    public class DeleteCarCommand : IRequest<bool>
    {
        public int CarId { get; }

        public DeleteCarCommand(int carToDeleteId)
        {
            this.CarId = carToDeleteId;
        }
    }
}
