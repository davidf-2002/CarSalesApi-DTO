using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarsApi.Data;
using CarsApi.Models;
using System.Net;

namespace CarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsAsyncController : ControllerBase
    {
        private readonly CarSalesDbContext _context;

        public CarsAsyncController(CarSalesDbContext context)
        {
            _context = context;
        }

        // GET: api/CarsAsync
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
          if (_context.Cars == null)
          {
              return NotFound();
          }
            var cars = await _context.Cars.ToListAsync();

            List<CarItemDTO> dto = cars.Select(c => new CarItemDTO
            {
                Name = c.Name,
                Manufacturer = c.Manufacturer,
                Fuel = Enum.GetName(typeof(Fuel), c.Fuel),
                Price = c.Price,
                RegistrationNumber = c.Registration,
            }).ToList();

            return Ok(dto);
        }

        // GET: api/CarsAsync/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
          if (_context.Cars == null)
          {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            var car = await _context.Cars.FindAsync(id);

            if (car == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return Ok(car);
        }

        // PUT: api/CarsAsync/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            _context.Entry(car).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/CarsAsync
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
          if (_context.Cars == null)
          {
                return StatusCode(StatusCodes.Status400BadRequest);
          }
            if (!ModelState.IsValid || CarExists(car.Id))
            {
                // Return bad request with validation errors
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            try
            {
                _context.Cars.Add(car);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
           
            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/CarsAsync/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            if (_context.Cars == null)
            {
                return NotFound();
            }
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            try {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            

            return NoContent();
        }

        private bool CarExists(int? id)
        {
            return (_context.Cars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
