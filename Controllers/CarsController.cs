using CarsApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarSalesDbContext _context;

        public CarsController(CarSalesDbContext context)
        {
            _context = context;
        }


        //[HttpGet]
        //public List<Car> Get()
        //{
        //    var cars = _context.Cars;
        //    return cars.ToList();
        //}

        //[HttpGet]
        //public ActionResult<IEnumerable<Car>> GetCars()
        //{
        //    if (_context.Cars == null)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //    return _context.Cars.ToList();
        //}


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            if (_context.Cars == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return await _context.Cars.ToListAsync();
        }

        // GET api/<CarsController>/5

        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            if (_context.Cars == null)
            {
                // http:500
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            Car car = _context.Cars.Find(id);

            if (car == null)
            {
                // http: 404
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }
            
            // http: 200
            return car;
        }

        [HttpGet("{manufacturer}/manufacturer")]
        public ActionResult<IEnumerable<Car>> GetCars(string manufacturer)
        {
            IEnumerable<Car> cars = null;
            if (_context.Cars == null)
            {
                // http:500
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }
            else
            {
                cars = _context.Cars.Where(c => c.Manufacturer.Equals(manufacturer));
            }


            if (cars == null || cars.Count() == 0)
            {
                // options here....
                // return cars.ToList()  is a 200 [] an empty list
                // return new StatusCodeResult((int)HttpStatusCode.NotFound);
                // null returns a 204 no content
                return null;
            }

            // http: 200 with data
            return cars.ToList();




        }

        // POST api/<CarsController>
        [HttpPost]
        public ActionResult<Car> PostCar(Car car)
        {

            if (!ModelState.IsValid)
            {
                // Return bad request with validation errors
                return new StatusCodeResult((int)HttpStatusCode.BadRequest); 
            }

            try
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
            catch (Exception ex) {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            return CreatedAtAction("GetCarById", new { id = car.Id }, car);
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public ActionResult PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                // Return bad request with validation errors
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
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

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int? id)
        {
            if (id == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);
            }

            if (_context.Cars == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            var car = _context.Cars.Find(id);

            if (car == null)
            {
                return NotFound();
            }

            try
            { 
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            return NoContent();
        }


        private bool CarExists(int id)
        {
            return (_context.Cars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
