using System;
using System.Collections.Generic;
using System.Linq;
using Refactoring.EncapsulateCollection;
using Xunit;

namespace Refactoring.Tests.EncapsulateCollection
{
    public class CustomerFacts
    {
        [Fact]
        void should_add_order_for_customer()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                Money = 100
            };
            var customer = new Customer
            {
                Name = "Kayla",
                Orders = new HashSet<Order>()
            };

            customer.Orders.Add(order);

            Assert.Single(customer.Orders);
            Assert.Equal(order.Id, customer.Orders.First().Id);
            Assert.Equal(order.Money, customer.Orders.First().Money);
        }

        [Fact]
        void should_remove_order_for_customer()
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                Money = 100
            };
            var customer = new Customer
            {
                Name = "Kayla",
                Orders = new HashSet<Order>
                {
                    order
                }
            };

            customer.Orders.Remove(order);

            Assert.Empty(customer.Orders);
        }
    }
}