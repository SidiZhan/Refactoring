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
            Assert.Equal("76EF4D19-7503-4449-90B1-5FB85ECB5CA3", customers[0]["id"]);
            Assert.Equal("Kayla", customers[0]["name"]);
            Assert.Equal("B4B14933-E8D0-4D77-A599-AAD44093E5C5", customers[1]["id"]);
            Assert.Equal("Nancy", customers[1]["name"]);
        }
    }
}
