using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public T Add(T newT);
        public T GetById(int tId);
        public T Update(T updatedT);
        public bool Delete(int tId);
    }
}
