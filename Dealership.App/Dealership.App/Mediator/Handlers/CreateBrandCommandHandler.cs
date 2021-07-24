using Dealership.App.Mediator.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Handlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, bool>
    {
        public Task<bool> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
