using Dealership.Domain.Entities;
using Dealership.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task<bool> Add(Car newCar)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAll()
        {
            throw new NotImplementedException();
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
