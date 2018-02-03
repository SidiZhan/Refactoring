using System.Collections.Generic;
using Refactoring.ChangeValueToReference;
using Xunit;

namespace Refactoring.Tests.ChangeValueToReference
{
    public class OrderTests
    {
        [Fact]
        public void get_all_report_for_one_user()
        {
            var orders = new List<Order>
            {
                new Order(new User("shengqi"), new List<Product>() {new Product("Pen", 2.5)}),
                new Order(new User("shengqi"), new List<Product>() {new Product("Pen", 2.5)}),
                new Order(new User("shengqi"), new List<Product>() {new Product("NoteBook", 2.5)}),
                new Order(new User("shengqi"), new List<Product>() {new Product("NoteBook", 2.5)}),
                new Order(new User("yanpei"), new List<Product>() {new Product("NoteBook", 5.5)}),
                new Order(new User("yanpei"), new List<Product>() {new Product("NoteBook", 20)}),
                new Order(new User("yanpei"), new List<Product>() {new Product("Pencil", 13)}),
            };

            var totalCostForShengqi = new Calculator().GetTotalCostForUser("shengqi", orders);
            Assert.Equal(10.0, totalCostForShengqi);
            var totalCostForYanpei = new Calculator().GetTotalCostForUser("yanpei", orders);
            Assert.Equal(38.5, totalCostForYanpei);
        }
    }
}
