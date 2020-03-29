using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Companion.Repository;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Companion.Persistance
{
    public abstract class MySqlRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext context;

        public MySqlRepository(DbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> FindAll()
        {
            return this.context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.context.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }



    }

    }
