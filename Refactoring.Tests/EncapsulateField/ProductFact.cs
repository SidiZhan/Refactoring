using Xunit;

namespace Refactoring.Tests.EncapsulateField
{
    public class ProductFact
    {
        [Fact]
        public void should_get_correct_price_when_exchange_rate_is_three()
        {
            var product = MockProvider.GetProductByIdWithExchangeRate(3,3);
            Assert.Equal(90, product.Price);
        }

//        [Fact]
//        public void should_get_zero_when_set_invalid_price()
//        {
//            var product = MockProvider.GetProductById(1);
//            product.Price = -10;
//            Assert.Equal(0, product.Price);
//        }

        #region

        /*
        #1  product only can get name, can not change name

        #2  lazy load(getter) : get{
                if(a == null){
                    a = new A();
                }
                return a;
            }

        #3  find get and set useage,debug

        */

        #endregion
    }
}