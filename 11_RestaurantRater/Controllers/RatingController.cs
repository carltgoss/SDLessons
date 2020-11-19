using _11_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _11_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        // Create

        // POST
        [HttpPost]
        public async Task<IHttpActionResult> PostRating(Rating model)
        {
            if (ModelState.IsValid)
            {
                Restaurant restaurant = await _context.Restaurants.FindAsync(model.RestaurantId);
                if (restaurant == null)
                {
                    return BadRequest("There is no restaurant with that Id");
                }

                _context.Ratings.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // Read

        // Get All
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Rating> ratings = await _context.Ratings.ToListAsync();
            return Ok(ratings);
        }
        
        //Get Ratings by restaurant
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            List<Rating> ratings = await _context.Ratings.Where(r => r.RestaurantId == id).ToListAsync();
            return Ok(ratings);
        }

        //GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Rating ratings = await _context.Ratings.FindAsync(id);

            if (ratings != null)
            {
                return Ok(ratings);
            }

            return NotFound(); // 404
        }

        // Update

        [HttpPut]
        public async Task<IHttpActionResult> UpdateRatings([FromUri] int id, [FromBody] Rating model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Rating ratings = await _context.Ratings.FindAsync(id);

            if (ratings == null)
            {
                return NotFound();
            }

            ratings.FoodScore = model.FoodScore;
            ratings.EnvironmentScore = model.EnvironmentScore;
            ratings.CleanlinessScore = model.CleanlinessScore;

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError();
        }
        // Delete

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRatingsById(int id)
        {
            Rating ratings = await _context.Ratings.FindAsync(id);

            if (ratings == null)
            {
                return NotFound();
            }

            _context.Ratings.Remove(ratings);

            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok();
            }

            return InternalServerError(); // 500
        }
    }
}
