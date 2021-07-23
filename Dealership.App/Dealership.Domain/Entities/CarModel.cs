using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain.Entities
{
    public class CarModel
    {
        public int CarModelId { get; set; }
        public string CarModelName { get; set; }
        public List<Car> Cars { get; set; }
    }
}
