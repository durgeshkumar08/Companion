using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Companion.Controllers
{
    [Produces("application/json")]
    [Route("api/Order")]
    [ApiController]
    public class OrderController : Controller
    {
        //private readonly c4eContext _context;

        //public OrderController(c4eContext context)
        //{
        //    _context = context;
        //}
        //[HttpGet]
        //public ActionResult<IEnumerable<Order>> Get()
        //{
        //    return _context.Order.ToList();
        //}

        //// GET: api/Order/5
        //[HttpGet("{id}")]
        //public ActionResult<Order> Get(int id)
        //{
        //    return _context.Order.Find(id);
        //}

        //// POST: api/Order
        //[HttpPost]
        //public bool Post([FromBody] Order order)
        //{
        //    _context.Entry(order).State = EntityState.Added;
        //    _context.Order.Add(order);
        //    return _context.SaveChanges() > 0;
        //}

        //// PUT: api/Order/5
        //[HttpPut("{id}")]
        //public bool Put([FromBody] Order order)
        //{
        //    _context.Entry(order).State = EntityState.Modified;
        //    _context.Order.Add(order);
        //    return _context.SaveChanges() > 0;
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public bool Delete(int id)
        //{
        //    _context.Remove(_context.Order.Find(id));
        //    return _context.SaveChanges() > 0;
        //}
    }
}
