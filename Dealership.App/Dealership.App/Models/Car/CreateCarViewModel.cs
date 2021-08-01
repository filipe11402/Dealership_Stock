using Dealership.App.Models.CarBrand;
using Dealership.App.Models.CarModel;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership.App.Models.Car
{
    public class CreateCarViewModel
    {
        public int CarId { get; set; }
        public int CarBrandId { get; set; }
        public int CarModelId { get; set; }
        public IEnumerable<CarBrandViewModel> CarBrands { get; set; }
        public IEnumerable<CarModelViewModel> CarModels { get; set; }
        public string ImageName { get; set; }
        public IFormFile Image { get; set; }
    }
}
