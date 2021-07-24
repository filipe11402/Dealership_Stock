using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IBrandRepository Brands { get; }
        int Commit();
    }
}
