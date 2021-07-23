using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public CarBrand Brand { get; set; }
        public CarModel Model { get; set; }
        public byte[] Image { get; set; }
    }
}
