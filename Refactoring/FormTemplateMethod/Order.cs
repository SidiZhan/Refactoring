using System.Collections.Generic;
using System.Linq;

namespace Refactoring.FormTemplateMethod
{
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public Order(List<Product> products)
        {
            Products = products;
        }

        public string GetTextOrder()
        {
            string result = $"There are {Products.Count} product in order\n";
            result += "The product list is :\n";

            foreach (var product in Products)
            {
                result += $"{product.Name} : {product.Price}\n";
            }

            result += $"Total price is {Products.Sum(p => p.Price)}\n";
            result += "Please pay in 1 hour";
            return result;
        }

        public string GetHtmlOrder()
        {
            string result = $"<h1>There are {Products.Count} product in order</h1><br/>";
            result += "The product list is :<br/>";

            foreach (var product in Products)
            {
                result += $"<p>{product.Name} : {product.Price}</p>";
            }

            result += $"Total price is {Products.Sum(p => p.Price)}<br/>";
            result += "<strong>Please pay in 1 hour</strong>";
            return result;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}