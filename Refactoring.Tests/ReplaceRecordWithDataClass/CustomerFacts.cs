using System.Linq;
using Refactoring.ReplaceRecordWithDataClass;
using Xunit;

namespace Refactoring.Tests.ReplaceRecordWithDataClass
{
    public class CustomerFacts
    {
        readonly CustomerCache cache;

        public CustomerFacts()
        {
            cache = new CustomerCache();
        }

        [Fact]
        void load_customers_from_cache()
        {
            var customers = cache.LoadAll().OrderBy(e => e["name"]).ToList();

            Assert.Equal(2, customers.Count());
            Assert.Equal("76EF4D19", customers[0]["id"]);
            Assert.Equal("Kayla", customers[0]["name"]);
            Assert.Equal("B4B14933", customers[1]["id"]);
            Assert.Equal("Nancy", customers[1]["name"]);
        }
    }
}
