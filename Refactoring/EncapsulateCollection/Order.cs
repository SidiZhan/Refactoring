using System;
using System.Collections.Generic;

namespace Refactoring.EncapsulateCollection
{
    public class Order
    {
        public Guid Id { get; set; }

        public double Money { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   Id.Equals(order.Id);
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<Guid>.Default.GetHashCode(Id);
        }
    }
}
