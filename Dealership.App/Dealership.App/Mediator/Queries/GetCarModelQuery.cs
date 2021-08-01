using Dealership.App.Models.CarModel;
using Dealership.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarModelQuery : IRequest<CarModel>
    {
        public int CarModelId { get; set; }

        public GetCarModelQuery(int carModelId)
        {
            this.CarModelId = carModelId;
        }
    }
}
