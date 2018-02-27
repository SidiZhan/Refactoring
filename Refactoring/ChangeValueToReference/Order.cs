using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ChangeValueToReference
{
    public class Calculator
    {
        public double GetTotalCostForUser(string userName, List<Order> orders)
        {
            return orders.Where(order => string.Equals(order.GetUserName(), userName))
                .SelectMany(order => order.Products)
                .Aggregate(0.0, (total, next) => total + next.Price);
        }
    }

    public class Order
    {
        User User { get; }
        public List<Product> Products { get; set; }

        public Order(User user, List<Product> products)
        {
            User = user;
            Products = products;
        }

        public string GetUserName()
        {
            return User.Name;
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public User(string name, string address = null)
        {
            Name = name;
            Address = address;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

}
