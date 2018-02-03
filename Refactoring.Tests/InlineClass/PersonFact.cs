using Refactoring.InlineClass;
using Xunit;

namespace Refactoring.Tests.InlineClass
{
    public class PersonFact
    {
        [Fact]
        public void should_get_telephone_number()
        {
            var person = new Person("kayla", "010", "123456");
            var number = person.GetTelephoneNumber();
            Assert.Equal("(010) 123456", number);
        }
    }
}