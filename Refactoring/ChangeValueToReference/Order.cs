using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ChangeValueToReference
{
    public class Calculator
    {
        public double GetTotalCostForUser(string userName, List<Order> orders)
        {
            return orders.Where(order => order.User.Equals(UserFactory.GetByName(userName)))
                .SelectMany(order => order.Products)
                .Aggregate(0.0, (total, next) => total + next.Price);
        }
    }

    public class Order
    {
        public User User { get; }
        public List<Product> Products { get; set; }

        public Order(User user, List<Product> products)
        {
            User = user;
            Products = products;
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

        protected bool Equals(User other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User) obj);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
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
