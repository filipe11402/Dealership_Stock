using Dealership.App.Models.CarModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarModelQuery : IRequest<CarModelViewModel>
    {
        public int CarModelId { get; set; }

        public GetCarModelQuery(int carModelId)
        {
            this.CarModelId = carModelId;
        }
    }
}
