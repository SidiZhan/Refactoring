using System;

namespace Refactoring.ExtractClass
{
    public class Customer
    {
        public string Name { get; }
        public int DaysRented { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public string City { get; set; }
        public string Block { get; set; }
        public string Street { get; set; }
        public double Distance { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void RentMovie(string title, double price, int daysRented, double distance = 0, string city = null, string block = null, string street = null)
        {
            Title = title;
            Price = price;
            DaysRented = daysRented;
            Distance = distance;
            City = city;
            Block = block;
            Street = street;
        }

        public double GetTotalCharge()
        {
            double transferFee = 0;

            if (Distance > 0 && Distance <= 10)
            {
                transferFee = 15;
            }

            if (Distance > 10)
            {
                transferFee = 15 + 3.5 * (Math.Round(Distance - 10));
            }
            return Price * DaysRented + transferFee;
        }

        public string GetAddress()
        {
            return $"Address: {Street}, {Block}, {City}";
        }
    }
}
