using System.Collections.Generic;

namespace Refactoring.ChangeBidirectionalAssociationToUnidirectional
{
    public class Order
    {
        public double price { get; set; }
        public Customer customer;

        public double DiscountedPrice()
        {
            return price * (1 - customer.Discount);
        }
    }

    public class Customer
    {
        public readonly HashSet<Order> orders = new HashSet<Order>();

        public double Discount { get; set; }
    }
}
