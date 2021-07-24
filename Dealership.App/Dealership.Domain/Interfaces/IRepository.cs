using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<bool> Add(T newT);
        public Task<T> GetById(int tId);
        public Task<bool> Update(T updatedT);
        public Task<bool> Delete(int tId);
    }
}
