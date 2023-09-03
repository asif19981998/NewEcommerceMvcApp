using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Contracts
{
    public interface IBaseRepository<T>
    {
        bool Add(T entity);
        Task<bool> AddAsync(T entity);
    }
}
