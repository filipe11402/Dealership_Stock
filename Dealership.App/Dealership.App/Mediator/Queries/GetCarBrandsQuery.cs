using Dealership.App.Models.CarBrand;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarBrandsQuery : IRequest<IEnumerable<CarBrandViewModel>>
    {
    }
}
