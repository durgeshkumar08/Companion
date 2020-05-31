using Companion.Repository;
using CompanionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Bll.PersonManagement
{
    public class PersonBll : IPersonBll
    {
        private readonly IPersonRepository _personRepository;
        public PersonBll(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAllPersons() 
        {
            return _personRepository.GetPeople();
        }
    }
}
