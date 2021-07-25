using Dealership.Domain;
using Dealership.Domain.Entities;
using Dealership.Domain.Interfaces;
using Dealership.Domain.Repositories;
using Dealership.Infrastructure.Context;
using Dealership.Infrastructure.Repositories;
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

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
        }
    }
}
