using Refactoring.IntroduceParameterObject;
using Xunit;

namespace Refactoring.Tests.IntroduceParameterObject
{
    public class SaySomethingFacts
    {
        [Fact]
        void should_say_hello()
        {
            Assert.Equal("Hello, First Middle Last", SaySomething.Hello("First", "Middle", "Last"));
        }

        [Fact]
        void should_say_hi()
        {
            Assert.Equal("Hi, First Middle Last", SaySomething.Hi("First", "Middle", "Last"));
        }
    }
}
