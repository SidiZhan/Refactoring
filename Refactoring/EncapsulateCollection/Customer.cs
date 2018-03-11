using System.Collections.Generic;

namespace Refactoring.EncapsulateCollection
{
    public class Customer
    {
        public string Name { get; set; }

        public HashSet<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>();
        }
    }
}
