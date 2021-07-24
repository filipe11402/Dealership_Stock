﻿using Dealership.Domain;
using Dealership.Domain.Entities;
using Dealership.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _dealershipDb;

        public BrandRepository(ApplicationDbContext dealershipDb)
        {
            this._dealershipDb = dealershipDb;
        }

        public async Task<bool> Add(CarBrand newBrand)
        {
           await this._dealershipDb.AddAsync(newBrand);
            return true;
        }

        public async Task<bool> Delete(int brandId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CarBrand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<CarBrand> GetById(int tId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(CarBrand updatedT)
        {
            throw new NotImplementedException();
        }
    }
}