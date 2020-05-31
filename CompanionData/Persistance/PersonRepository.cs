using Microsoft.EntityFrameworkCore;
using CompanionData.Models;
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

        public List<Person> GetPeople()
        {
            return FindAll().ToList();
        }

    }
}
