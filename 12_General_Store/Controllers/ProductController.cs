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
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //Create
        [HttpPost]
        public async Task<IHttpActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        //Read
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        //Update
        [HttpPut]
        [ActionName("Update")]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] Product model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            product.ProductName = model.ProductName;
            product.Quantity = model.Quantity;
            product.price = model.price;
            product.UPC = model.UPC;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }

        [HttpPut]
        [ActionName("Restock")]
        public async Task<IHttpActionResult> Restock([FromUri] int id, [FromBody] Restock model )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400
            }

            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }
        
            product.Quantity += model.Quantity;
           
            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }

        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteProduct(int id)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound(); // 404
            }

            _context.Products.Remove(product);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();

        }
    }
}
