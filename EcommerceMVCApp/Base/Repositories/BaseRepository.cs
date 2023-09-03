using Base.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {
        private DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        DbSet<T> Table => _dbContext.Set<T>();
        public bool Add(T entity)
        {
            Table.Add(entity);
            return SaveChanges();
        }

        public Task<bool> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public  bool SaveChanges()
        {
           return _dbContext.SaveChanges()>1;
        }
    }
}
