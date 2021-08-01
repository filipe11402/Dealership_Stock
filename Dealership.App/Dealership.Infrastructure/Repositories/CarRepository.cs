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

        public async Task<bool> Delete(int carId)
        {
            var carToDelete = await GetById(carId);
            if (carToDelete == null) 
            {
                return false;
            }
            this._dealershipDb.Remove(carToDelete);

            return true;
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return this._dealershipDb.Cars.Include(car => car.Brand).Include(car => car.Model);
        }

        public async Task<Car> GetById(int? carId)
        {
            var fetchedCar = await this._dealershipDb.Cars.FirstOrDefaultAsync(car => car.CarId == carId);
            fetchedCar.Brand = await this._dealershipDb.Brands.FirstOrDefaultAsync(car => car.Cars.Contains(fetchedCar));
            fetchedCar.Model = await this._dealershipDb.Models.FirstOrDefaultAsync(car => car.Cars.Contains(fetchedCar));
            if (fetchedCar == null) 
            {
                return null;
            }

            return fetchedCar;
        }

        public bool Update(Car updatedCar)
        {
            var response = this._dealershipDb.Cars.Update(updatedCar);

            return true;
        }
    }
}
