using Microsoft.EntityFrameworkCore;
using Companion.Models;
using Companion.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Companion.Persistance
{
    public class PersonRepository : MySqlRepository<Person>, IPersonRepository
    {
        public PersonRepository(c4eContext context)
            : base(context)
        {
        }

        public void Create(Person entity)
        {
           this.Create(entity);
        }

        public void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Person> FindAll()
        {
            return this.FindAll();
        }
        public IQueryable<Person> FindByCondition(Expression<Func<Person, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Person entity)
        {
            this.Update(entity);
        }
    }
}
