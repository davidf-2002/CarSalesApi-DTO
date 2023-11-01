namespace CarsApi.Data
{
    public class Car
    {
        public Car(int? id,
            string name,
            string manufacturer,
            int year,
            Fuel fuel,
            double price,
            string registration,
            DateTime dateAdded,
            bool sold)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
            Fuel = fuel;
            Price = price;
            Registration = registration;
            DateAdded = dateAdded;
            Sold = sold;
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public Fuel Fuel { get; set; }
        public double Price { get; set; }
        public string Registration { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Sold { get; set; }

        public override string? ToString()
        {
            return Id + ": " + Manufacturer + " - " +
                Name + "(" + Year + ") £" + Price + " "
                + Fuel + "(" +
                DateAdded.ToShortDateString() + ") " +
                (Sold ? "**" : "");
        }
    }
}
