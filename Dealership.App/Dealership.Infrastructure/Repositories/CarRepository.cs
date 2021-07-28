using Dealership.Domain.Entities;
using Dealership.Domain.Repositories;
using Dealership.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _dealershipDb;

        public CarRepository(ApplicationDbContext dealershipDb)
        {
            this._dealershipDb = dealershipDb;
        }
        public async Task<bool> Add(Car newCar)
        {
            var response = await this._dealershipDb.Cars.AddAsync(newCar);
            if (response == null) 
            {
                return false;
            }

            return true;
        }

        public Task<bool> Delete(int carId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return this._dealershipDb.Cars.Include(car => car.Brand).Include(car => car.Model);
        }

        public Task<Car> GetById(int? carId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Car updatedCar)
        {
            throw new NotImplementedException();
        }
    }
}
