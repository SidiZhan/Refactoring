using Refactoring.IntroduceForeignMethod;
using Xunit;

namespace Refactoring.Tests.IntroduceForeignMethod
{
    public class MyNameFacts
    {
        [Fact]
        void should_get_full_name()
        {
            Assert.Equal("Last, First Middle", new MyName("First", "Middle", "Last").GetFullName());
        }
    }
}