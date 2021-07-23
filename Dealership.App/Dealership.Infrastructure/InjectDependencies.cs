using Dealership.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure
{
    public static class InjectDependencies
    {
        public static void AddInfrastructure(this IServiceCollection services) 
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlite(@"Data Source=C:\Users\Filipe Encarnacao\Desktop\C#\Dealership_stock\Dealership.db")   
            );
        }
    }
}
