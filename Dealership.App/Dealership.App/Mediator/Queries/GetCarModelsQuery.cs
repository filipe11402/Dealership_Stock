using Dealership.App.Models.CarModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarModelsQuery : IRequest<IEnumerable<CarModelViewModel>>
    {
    }
}
