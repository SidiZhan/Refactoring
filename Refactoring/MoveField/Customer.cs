namespace Refactoring.MoveField
{
    public class Customer
    {
        public string Name { get; }
        public Rental Rental { get; set; }
        public int DaysRented { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void RentMovie(Movie movie, int daysRented)
        {
            Rental = new Rental(movie);
            DaysRented = daysRented;
        }

        public double GetTotalCharge()
        {
            return Rental.GetCharge(DaysRented);
        }
    }
}
