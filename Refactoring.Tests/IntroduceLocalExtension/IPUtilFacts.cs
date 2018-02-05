using System.Threading.Tasks;
using Refactoring.IntroduceLocalExtension;
using Xunit;

namespace Refactoring.Tests.IntroduceLocalExtension
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