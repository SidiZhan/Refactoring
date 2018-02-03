using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ChangeValueToReference
{
    public class Calculator
    {
        public double GetTotalCostForUser(string userName, List<Order> orders)
        {
            return orders.Where(order => string.Equals(order.User.Name, userName))
                .SelectMany(order => order.Products)
                .Aggregate(0.0, (total, next) => total + next.Price);
        }
    }

    public class Order
    {
        public Order(User user, List<Product> products)
        {
            User = user;
            Products = products;
        }
        public User User { get; set; }
        public List<Product> Products { get; set; }
        public string GetUserAddress()
        {
            return User.Address;
        }

        public string GetUserPhoneNumber()
        {
            return User.PhoneNumber;
        }
    }

    public class User
    {
        public User(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

}
