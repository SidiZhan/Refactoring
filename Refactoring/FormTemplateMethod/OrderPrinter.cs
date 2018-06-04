using System.Linq;

namespace Refactoring.FormTemplateMethod
{
    public class OrderPrinter{}

    public class TextOrderPrinter : OrderPrinter
    {
        public string GetOrder(Order order)
        {
            string result = $"There are {order.Products.Count} product in order\n";
            result += "The product list is :\n";

            foreach (var product in order.Products)
            {
                result += $"{product.Name} : {product.Price}\n";
            }

            result += $"Total price is {order.Products.Sum(p => p.Price)}\n";
            result += "Please pay in 1 hour";
            return result;
        }
    }

    public class HtmlOrderPrinter : OrderPrinter
    {
        public string GetOrder(Order order)
        {
            string result = $"<h1>There are {order.Products.Count} product in order</h1><br/>";
            result += "The product list is :<br/>";

            foreach (var product in order.Products)
            {
                result += $"<p>{product.Name} : {product.Price}</p>";
            }

            result += $"Total price is {order.Products.Sum(p => p.Price)}<br/>";
            result += "<strong>Please pay in 1 hour</strong>";
            return result;
        }
    }
}
