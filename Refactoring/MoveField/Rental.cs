namespace Refactoring.MoveField
{
    public class Rental
    {
        public Movie Movie { get; }

        public Rental(Movie movie)
        {
            Movie = movie;
        }

        public double GetCharge(int daysRented)
        {
            return Movie.Price * daysRented;
        }
    }
}