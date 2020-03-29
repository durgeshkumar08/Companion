using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companion.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //private readonly c4eContext _context;

        //public PersonController(c4eContext context)
        //{
        //    _context = context;
        //}
        //// GET: api/Person
        //[HttpGet]
        //public ActionResult<IEnumerable<Person>> Get()
        //{
        //    return _context.Person.ToList();
        //}

        //// GET: api/Person/5
        //[HttpGet("{id}")]
        //public ActionResult<Person> Get(int id)
        //{
        //    return _context.Person.Find(id);
        //}

        //// POST: api/Person
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Person/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
