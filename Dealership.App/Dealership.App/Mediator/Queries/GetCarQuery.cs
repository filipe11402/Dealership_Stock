using Dealership.App.Models.Car;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Mediator.Queries
{
    public class GetCarQuery : IRequest<UpdateCarViewModel>
    {
        public int CarId { get; set; }

        public GetCarQuery(int carId)
        {
            this.CarId = carId;
        }
    }
}
