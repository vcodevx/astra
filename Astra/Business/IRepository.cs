using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Astra.Business
{
    public interface IRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        T Find(Guid Id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
