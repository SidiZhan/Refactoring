using Refactoring.ReplaceInheritanceWithDelegation;
using Xunit;

namespace Refactoring.Tests.ReplaceInheritanceWithDelegation
{
    public class ShoppingCartFacts
    {
        readonly ShoppingCart cart = new ShoppingCart();

        [Fact]
        void should_can_add_goods()
        {
            cart.Add("Goods 001");

            Assert.Equal(1, cart.Count);
        }

        [Fact]
        void should_can_remove_goods()
        {
            cart.Add("Goods 001");
            cart.Remove("Goods 001");

            Assert.Equal(0, cart.Count);
        }
    }
}
