using Dealership.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> Brands { get; set; }
        public DbSet<CarModel> Models { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base (options)
        {
        }
    }
}
