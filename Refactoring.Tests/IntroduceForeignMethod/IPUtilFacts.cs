using System.Threading.Tasks;
using Refactoring.IntroduceForeignMethod;
using Xunit;

namespace Refactoring.Tests.IntroduceForeignMethod
{
    public class IPUtilFacts
    {
        [Fact]
        async Task should_get_city()
        {
            var city = await IPUtil.GetCity("203.128.32.0");

            Assert.Equal("Beijing", city);
        }
    }
}