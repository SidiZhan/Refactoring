using Refactoring.MoveField;
using Xunit;

namespace Refactoring.Tests.MovieField
{
    public class CustomerGetTotalChargeFacts
    {
        [Fact]
        public void should_get_correct_charge()
        {
            var customer = new Customer("yan");
            var movie = new Movie("Ice", 5);
            customer.RentMovie(movie, 2);

            Assert.Equal(10, customer.GetTotalCharge());
        }
    }
}
