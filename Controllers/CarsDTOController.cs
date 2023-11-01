using CarsApi.Data;
using CarsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDTOController : ControllerBase
    {
        private readonly CarSalesDbContext _context;

        public CarsDTOController(CarSalesDbContext context)
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
        //        return NotFound();
        //    }
        //    return _context.Cars.ToList();
        //}


        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarItemDTO>>> GetCars()
        {
            if (_context.Cars == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
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

        // GET api/<CarsController>/VB508B
        [HttpGet("{RegistrationNumber}")]
        public async Task<ActionResult<CarItemDTO>> GetCarByReg(string RegistrationNumber)
        {
            if (_context.Cars == null)
            {
                // http:500
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            Car car = await _context.Cars.FirstOrDefaultAsync(c => c.Registration.Equals(RegistrationNumber));

            if (car == null)
            {
                // http: 404
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }

            CarItemDTO dto = new CarItemDTO
            {
                Name = car.Name,
                Manufacturer = car.Manufacturer,
                Fuel = Enum.GetName(typeof(Fuel), car.Fuel),
                Price = car.Price,
                RegistrationNumber = car.Registration,
            };

            // http: 200
            return Ok(dto);
        }


        [HttpGet("{manufacturer}/manufacturer")]
        public async Task<ActionResult<IEnumerable<CarItemDTO>>> GetCars(string manufacturer)
        {
            IEnumerable<Car> cars = null;

            if (_context.Cars == null)
            {
                // http:500
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }
            else
            {
                cars = await _context.Cars.Where(c => c.Manufacturer.Equals(manufacturer)).ToListAsync();
            }

            if (cars == null || !cars.Any())
            {
                // options here....
                // return Ok(new List<CarItemDTO>())  is a 200 [] an empty list
                // return new StatusCodeResult((int)HttpStatusCode.NotFound);
                // null returns a 204 no content
                return Ok(new List<CarItemDTO>());
            }

            List<CarItemDTO> dto = cars.Select(c => new CarItemDTO
            {
                Name = c.Name,
                Manufacturer = c.Manufacturer,
                Fuel = Enum.GetName(typeof(Fuel), c.Fuel),
                Price = c.Price,
                RegistrationNumber = c.Registration,
            }).ToList();

            // http: 200
            return Ok(dto);
        }

        // POST api/<CarsController>
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(CarItemDTO car)
        {
            if (!ModelState.IsValid || CarExists(car.RegistrationNumber) || FuelTypeInvalid(car.Fuel) || RegNotValid(car.RegistrationNumber))
            {
                // Return bad request with validation errors
                return BadRequest();
            }

            try
            {
                Car newCar = new Car(null, car.Name, car.Manufacturer, CalculateYear(car.RegistrationNumber), ParseFuelType(car.Fuel), car.Price, car.RegistrationNumber, DateTime.Now, false);

                _context.Cars.Add(newCar);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCarByReg", new { RegistrationNumber = newCar.Registration }, car);
            }
            catch (DbUpdateConcurrencyException)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }
        }



        // PUT api/<CarsController>/5
        [HttpPut("{RegistrationNumber}")]
        public ActionResult PutCar(string RegistrationNumber, CarItemDTO car)
        {
            if (RegistrationNumber != car.RegistrationNumber)
            {
                return BadRequest();
            }

            var existingCar = _context.Cars.FirstOrDefault(c => c.Registration.Equals(RegistrationNumber));

            if (existingCar == null)
            {
                return NotFound();
            }

            if (ValidPrice((int)car.Price))
            {
                // Update properties of the existing car entity
                existingCar.Price = car.Price;
            }
            else
            {
                return BadRequest();
            }

            try
            {
                _context.Update(existingCar);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                 return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            return NoContent();
        }



        // DELETE api/<CarsController>/5
        [HttpDelete("{RegistrationNumber}")]
        public async Task<ActionResult> DeleteCar(string RegistrationNumber)
        {
            if (_context.Cars == null)
            {
                // http:500
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            Car car = await _context.Cars.FirstOrDefaultAsync(c => c.Registration.Equals(RegistrationNumber));

            if (car == null)
            {
                // http: 404
                return new StatusCodeResult((int)HttpStatusCode.NotFound);
            }

            try
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return new StatusCodeResult((int)HttpStatusCode.InternalServerError);
            }

            return NoContent();
        }


        #region private methods


        private bool ValidPrice(int price)
        {
            if (price is int)
            {
                // Check if car.Price is positive
                if ((int)price > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool RegNotValid(string registrationNumber)
        {
            bool notValid = true;
            // Ensure the registrationNumber is not null and has at least 4 characters
            if (registrationNumber != null && registrationNumber.Length >= 4)
            {
                // Use a regular expression to match digits at the 3rd and 4th positions
                string pattern = @"^\D{2}\d{2}";
                if (Regex.IsMatch(registrationNumber, pattern))
                    { notValid = false; }
            }

            // Return false if the registrationNumber is invalid
            return notValid;
        }

        private bool IsFuelTypeValid(Fuel fuelType)
        {
            // Check if the provided fuel type is within the enum values
            return Enum.IsDefined(typeof(Fuel), fuelType);
        }


        /// <summary>
        /// In this universe the year of manufacture is ALLWAYS defined by the 3rd and 4th chars
        /// SO VB23A1E4X would be 2023
        /// Not  real but hey its fun to create your own world sometimes
        /// </summary>
        /// <param name="registrationNumber"></param>
        /// <returns>Year of Manuacture</returns>
        private int CalculateYear(string registrationNumber)
        {

            // Ensure the input string is not null and has at least 4 characters
            if (registrationNumber != null && registrationNumber.Length >= 4)
            {
                // Extract the 3rd and 4th characters from the string
                char thirdChar = registrationNumber[2];
                char fourthChar = registrationNumber[3];

                // Create the composed string
                string composedString = "20" + thirdChar + fourthChar;

                // Convert the composed string to an integer
                if (int.TryParse(composedString, out int result))
                {
                    return result;
                }
            }

            // Return a default value if the input is invalid
            return 0;
        }

        static Fuel ParseFuelType(string input)
        {

            if (Enum.TryParse<Fuel>(input, out Fuel result))
            {
                return result;
            }
            else
            {
                // Handle the case where the input string doesn't match any enum value.
                return 0;
            }
        }

        static bool FuelTypeInvalid(string input)
        {

            if (Enum.TryParse<Fuel>(input, out Fuel result))
            {
                return false;
            }
            else
            {
                
                return true;
            }
        }

        private bool CarExists(int id)
        {
            return (_context.Cars?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private bool CarExists(string registration)
        {
            var result = _context.Cars?.FirstOrDefault(e => e.Registration.Equals(registration));
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
