using System.Xml.Schema;
using Refactoring.ReplaceSubclassWithField;
using Xunit;

namespace Refactoring.Tests.ReplaceSubclassWithField
{
    public class PersonFacts
    {
        [Fact]
        void should_get_isMale_and_code_for_male()
        {
            var male = new Male();
            Assert.True(male.IsMale());
            Assert.Equal('M', male.GetCode());
        }

        [Fact]
        void should_get_isMale_and_code_for_female()
        {
            var female = new Female();
            Assert.False(female.IsMale());
            Assert.Equal('F', female.GetCode());
        }
    }
}
