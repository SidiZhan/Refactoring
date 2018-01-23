namespace Refactoring.MoveField
{
    public class Customer
    {
        public string Name { get; }
        public Rental Rental { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void RentMovie(Movie movie, int daysRented)
        {
            Rental = new Rental(movie, daysRented);
        }

        public double GetTotalCharge()
        {
            return Rental.GetCharge();
        }
    }
}
