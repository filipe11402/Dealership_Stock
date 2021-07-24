using Dealership.App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetBrandsQuery : IRequest<IEnumerable<BrandViewModel>>
    {
    }
}
