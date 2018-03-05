using Refactoring.ReplaceArrayWithObject;
using Xunit;

namespace Refactoring.Tests.ReplaceArrayWithObject
{
    public class OrderFacts
    {
        [Fact]
        public void should_get_total_price()
        {
            var order = new Order("Notebook", "2.1", "2");
            var totalPrice = order.GetTotalPrice();
            Assert.Equal(4.2, totalPrice);
        }
    }
}
