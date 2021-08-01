using Dealership.App.Models.CarBrand;
using Dealership.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarBrandQuery : IRequest<CarBrand>
    {
        public int? CarBrandId { get; set; }

        public GetCarBrandQuery(int? carBrandId)
        {
            this.CarBrandId = carBrandId;
        }
    }
}
