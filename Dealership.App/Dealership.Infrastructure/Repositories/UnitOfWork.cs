using Dealership.Domain;
using Dealership.Domain.Interfaces;
using Dealership.Domain.Repositories;
using Dealership.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBrandRepository Brands { get; }
        public ICarModelRepository Models { get; }
        private readonly ApplicationDbContext _DealershipDb;

        public UnitOfWork(IBrandRepository brands, ICarModelRepository models, ApplicationDbContext dealershipDb)
        {
            this.Brands = brands;
            this.Models = models;
            this._DealershipDb = dealershipDb;
        }

        public int Commit()
        {
            return this._DealershipDb.SaveChanges();
        }
    }
}
