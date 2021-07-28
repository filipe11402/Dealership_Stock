using Dealership.App.Models.CarBrand;
using Dealership.App.Models.CarModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Models.Car
{
    public class CarViewModel
    {
        public int CarId { get; set; }
        public CarModelViewModel CarModel { get; set; }
        public CarBrandViewModel CarBrand { get; set; }
        public string ImageName { get; set; }
    }
}
