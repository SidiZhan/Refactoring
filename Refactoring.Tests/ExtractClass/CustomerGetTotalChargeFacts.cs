using Refactoring.ExtractClass;
using Xunit;

namespace Refactoring.Tests.ExtractClass
{
    public class CustomerGetTotalChargeFacts
    {
        [Fact]
        public void should_get_correct_charge()
        {
            var customer = new Customer("yan");
            customer.RentMovie("Once upon a time in America", 8.42, 2, 10);
            Assert.Equal(31.84, customer.GetTotalCharge());
        }

        [Fact]
        public void should_get_correct_charge_when_distance_over_10_km()
        {
            var customer = new Customer("yan");
            customer.RentMovie("Gone With the Wind", 1.52, 2, 11.6, "Beijing", "Chaoyang", "Dongzhimen Street");
            Assert.Equal(25.04, customer.GetTotalCharge());
            Assert.Equal("Address: Dongzhimen Street, Chaoyang, Beijing", customer.GetAddress());
        }
    }
}
