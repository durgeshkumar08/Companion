using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companion.Bll.PersonManagement;
using CompanionData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Companion.Controllers
{
    [Route("api/[controller]")]
    [Route("api/Value")]

    [ApiController]
    public class ValuesController : Controller
    {

        private readonly ILogger<ValuesController> _logger;
        private readonly IPersonBll _personBll;
        public ValuesController(ILogger<ValuesController> logger, IPersonBll personBll)
        {
            _logger = logger;
            _personBll = personBll;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            _logger.LogInformation("test");
            return _personBll.GetAllPersons();
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
