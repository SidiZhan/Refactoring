using Refactoring.ReplaceDelegationWithInheritance;
using Xunit;

namespace Refactoring.Tests.ReplaceDelegationWithInheritance
{
    public class DeveloperFacts
    {
        [Fact]
        void should_create_new_developer()
        {
            var developer = new Developer("Mengfan", Gender.Male);

            Assert.Equal("Mengfan", developer.Name);
            Assert.Equal(Gender.Male, developer.Gender);
        }
    }
}
