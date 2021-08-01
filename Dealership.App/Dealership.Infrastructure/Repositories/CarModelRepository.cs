using Dealership.Domain.Entities;
using Dealership.Domain.Repositories;
using Dealership.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly ApplicationDbContext _dealershipDb;

        public CarModelRepository(ApplicationDbContext dealershipDb)
        {
            this._dealershipDb = dealershipDb;
        }

        public async Task<bool> Add(CarModel newCarModel)
        {
            var addedModel = await this._dealershipDb.Models.AddAsync(newCarModel);
            if (addedModel == null) 
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Delete(int carModelId)
        {
            var carModel = await GetById(carModelId);
            if (carModel == null) 
            {
                return false;
            }

            this._dealershipDb.Models.Remove(carModel);

            return true;
        }

        public async Task<IEnumerable<CarModel>> GetAll()
        {
            return this._dealershipDb.Models;
        }

        public async Task<CarModel> GetById(int? carModelId)
        {
            var carModel = await this._dealershipDb.Models.FindAsync(carModelId);
            if (carModel == null) 
            {
                return null;
            }

            return carModel;
        }

        public bool Update(CarModel updatedCarModel)
        {
            this._dealershipDb.Models.Update(updatedCarModel);

            return true;
        }
    }
}
