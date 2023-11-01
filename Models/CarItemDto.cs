namespace CarsApi.Models
{
    public class CarItemDTO
    {
        public CarItemDTO() { }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string RegistrationNumber { get; set; }
        public string Fuel { get; set; }
        public double Price { get; set; }
    }
}
