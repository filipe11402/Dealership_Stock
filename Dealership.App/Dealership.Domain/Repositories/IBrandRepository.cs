using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain
{
    public interface IBrandRepository : IRepository<CarBrand>
    {
    }
}
