using System.Collections.Generic;

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
            return new TextOrderPrinter().GetOrder(this);
        }

        public string GetHtmlOrder()
        {
            return new HtmlOrderPrinter().GetOrder(this);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}