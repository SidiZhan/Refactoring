using System.Collections.Generic;
using Refactoring.FormTemplateMethod;
using Xunit;

namespace Refactoring.Tests.FormTemplateMethod
{
    public class OrderFact
    {
        readonly Order order;
        public OrderFact()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "product 1",
                    Price = 100
                },
                new Product
                {
                    Name = "product 2",
                    Price = 200
                }
            };
            order = new Order(products);
        }

        [Fact]
        public void should_get_text_order()
        {
            string result = $"There are 2 product in order\n";
            result += "The product list is :\n";
            result += $"product 1 : 100\n";
            result += $"product 2 : 200\n";
            result += $"Total price is 300\n";
            result += "Please pay in 1 hour";
            Assert.Equal(result,order.GetTextOrder());
        }

        [Fact]
        public void should_get_html_order()
        {
            string result = $"<h1>There are 2 product in order</h1><br/>";
            result += "The product list is :<br/>";
            result += "<p>product 1 : 100</p>";
            result += "<p>product 2 : 200</p>";
            result += "Total price is 300<br/>";
            result += "<strong>Please pay in 1 hour</strong>";
            Assert.Equal(result, order.GetHtmlOrder());
        }
    }
}
