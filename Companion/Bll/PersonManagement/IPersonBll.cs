using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanionData.Models;

namespace Companion.Bll.PersonManagement
{
    public interface IPersonBll
    {
        List<Person> GetAllPersons();
    }
}
