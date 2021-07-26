using Dealership.Domain;
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

        public async Task<bool> Add(CarBrand newCarBrand)
        {
            var response = await this._dealershipDb.AddAsync(newCarBrand);
            if (response == null) 
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Delete(int carBrandId)
        {
            var carBrandDto = await GetById(carBrandId);

            if (carBrandDto == null) 
            {
                return false;
            }

            this._dealershipDb.Brands.Remove(carBrandDto);

            return true;
        }

        public async Task<IEnumerable<CarBrand>> GetAll()
        {
            return this._dealershipDb.Brands;
        }

        public async Task<CarBrand> GetById(int? carBrandId)
        {
            return await this._dealershipDb.Brands.FindAsync(carBrandId);
        }

        public bool Update(CarBrand updatedCarBrand)
        {
            var response = this._dealershipDb.Brands.Update(updatedCarBrand);

            return true;
        }
    }
}
