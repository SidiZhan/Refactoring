using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ReplaceRecordWithDataClass
{
    public class CustomerCache
    {
        readonly HashSet<Customer> cache;

        public CustomerCache()
        {
            cache = new HashSet<Customer>
            {
                new Customer
                {
                    ["id"] = "76EF4D19-7503-4449-90B1-5FB85ECB5CA3",
                    ["name"] = "Kayla"
                },
                new Customer
                {
                    ["id"] = "B4B14933-E8D0-4D77-A599-AAD44093E5C5",
                    ["name"] = "Nancy"
                }
            };
        }

        public IList<Customer> LoadAll()
        {
            return cache.ToList();
        }
    }
}
