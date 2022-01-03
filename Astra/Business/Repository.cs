using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Astra.Business
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context = null; 
        public Repository(DbContext context)
        {
            _context = context;
        }
        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public T Find(Guid Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Update(T obj)
        {
          _context.Set<T>().Update(obj);
        }
    }
}
