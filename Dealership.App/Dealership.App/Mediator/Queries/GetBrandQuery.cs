using Dealership.App.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetBrandQuery : IRequest<BrandViewModel>
    {
        public int? BrandId { get; set; }

        public GetBrandQuery(int? brandId)
        {
            this.BrandId = brandId;
        }
    }
}
