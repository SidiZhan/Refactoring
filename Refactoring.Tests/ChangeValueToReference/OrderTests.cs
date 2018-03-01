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
                new Order(UserFactory.GetByName("shengqi"), new List<Product> {new Product("Pen", 2.5), new Product("Pen", 2.5)}),
                new Order(UserFactory.GetByName("shengqi"), new List<Product> {new Product("Pen", 2.5)}),
                new Order(UserFactory.GetByName("shengqi"), new List<Product> {new Product("NoteBook", 2.5)}),
                new Order(UserFactory.GetByName("shengqi"), new List<Product> {new Product("NoteBook", 2.5)}),
                new Order(UserFactory.GetByName("yanpei"), new List<Product> {new Product("NoteBook1", 5.5)}),
                new Order(UserFactory.GetByName("yanpei"), new List<Product> {new Product("NoteBook2", 20)}),
                new Order(UserFactory.GetByName("yanpei"), new List<Product> {new Product("Pencil", 13)}),
            };
            var totalCostForUser1 = new Calculator().GetTotalCostForUser("shengqi", orders);
            Assert.Equal(12.5, totalCostForUser1);
            var totalCostForUser2 = new Calculator().GetTotalCostForUser("yanpei", orders);
            Assert.Equal(38.5, totalCostForUser2);
        }
    }
}
