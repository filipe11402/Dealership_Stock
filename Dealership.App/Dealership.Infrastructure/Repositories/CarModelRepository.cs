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
            var response = await this._dealershipDb.Models.AddAsync(newCarModel);
            if (response == null) 
            {
                return false;
            }

            return true;
        }

        public async Task<bool> Delete(int carModelId)
        {
            CarModel carModelToDelete = await GetById(carModelId);
            var response = this._dealershipDb.Models.Remove(carModelToDelete);

            return true;
        }

        public async Task<IEnumerable<CarModel>> GetAll()
        {
            return this._dealershipDb.Models;
        }

        public async Task<CarModel> GetById(int? carModelId)
        {
            CarModel fetchedCarModel = await this._dealershipDb.Models.FindAsync(carModelId);
            if (fetchedCarModel == null) 
            {
                return null;
            }

            return fetchedCarModel;
        }

        public bool Update(CarModel updatedCarModel)
        {
            var response = this._dealershipDb.Models.Update(updatedCarModel);

            return true;
        }
    }
}
