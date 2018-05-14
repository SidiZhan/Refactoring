using Refactoring.IntroduceParameterObject;
using Xunit;

namespace Refactoring.Tests.IntroduceParameterObject
{
    public class SaySomethingFacts
    {
        readonly string firstName;
        readonly string middleName;
        readonly string lastName;

        public SaySomethingFacts()
        {
            firstName = "First";
            middleName = "Middle";
            lastName = "Last";
        }

        [Fact]
        void should_say_hello()
        {
            Assert.Equal("Hello, First Middle Last", SaySomething.Hello(firstName, middleName, lastName));
        }

        [Fact]
        void should_say_hi()
        {
            Assert.Equal("Hi, First Middle Last", SaySomething.Hi(firstName, middleName, lastName));
        }
    }
}
