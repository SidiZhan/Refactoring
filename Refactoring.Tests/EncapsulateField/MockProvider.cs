using System.Collections.Generic;
using Refactoring.EncapsulateField;
namespace Refactoring.Tests.EncapsulateField
{
    public class MockProvider
    {
        static readonly Dictionary<int, Product> Products = new Dictionary<int, Product>
        {
            {1, new Product(1, "product1", 10)},
            {2, new Product(1, "product2", 20)},
            {3, new Product(1, "product3", 30)},
            {4, new Product(1, "product4", 40)},
        };

        public static Product GetProductById(int id)
        {
            return Products[id];
        }

        public static Product GetProductByIdWithExchangeRate(int id, double rate)
        {
            var product = Products[id];
            product.Price = product.Price * rate;
            return product;
        }
    }
}