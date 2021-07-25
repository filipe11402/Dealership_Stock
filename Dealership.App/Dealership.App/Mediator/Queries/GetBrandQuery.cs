using Dealership.App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetBrandQuery : IRequest<CarBrandViewModel>
    {
        public int? CarBrandId { get; set; }

        public GetBrandQuery(int? carBrandId)
        {
            this.CarBrandId = carBrandId;
        }
    }
}
