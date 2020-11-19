using _12_General_Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_General_Store.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //Create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        //Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Customer> customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }
    }
}
