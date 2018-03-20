using System.Collections.Generic;
using System.Linq;

namespace Refactoring.ReplaceRecordWithDataClass
{
    public class CustomerCache
    {
        readonly string[][] cache;

        public CustomerCache()
        {
            cache = new string[][]
            {
                new string[] {"76EF4D19", "Kayla"},
                new string[] {"B4B14933", "Nancy"}
            };
        }

        public IList<Dictionary<string, string>> LoadAll()
        {
            return cache.Select(
                e => new Dictionary<string, string>()
                {
                    ["id"] = e[0],
                    ["name"] = e[1]
                }).ToList();
        }
    }
}
