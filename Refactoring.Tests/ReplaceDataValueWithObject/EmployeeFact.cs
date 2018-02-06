using Refactoring.ReplaceDataValueWithObject;
using Xunit;

namespace Refactoring.Tests.ReplaceDataValueWithObject
{

    public class EmployeeFact
    {
        [Fact]
        public void should_get_primary_email_prefix()
        {
            Employee employee = new Employee("first", "employer", 20000, "first@TW.com");
            string primaryEmailPrefix = employee.GetPrimaryEmailPrefix();
            Assert.Equal("first", primaryEmailPrefix);
        }

        [Fact]
        public void should_get_primary_email_postfix()
        {
            Employee employee = new Employee("first", "employer", 20000, "first@TW.com");
            string primaryEmailPostfix = employee.GetPrimaryEmailPostfix();
            Assert.Equal("TW.com", primaryEmailPostfix);
        }

        [Fact]
        public void should_get_company_info_from_primary_email()
        {
            Employee employee = new Employee("first", "employer", 20000, "first@TW.com");
            string primaryEmailPostfix = employee.GetCompanyInfoFromPrimaryEmail();
            Assert.Equal("TW", primaryEmailPostfix);
        }

        [Fact]
        public void should_get_second_email_prefix()
        {
            Employee employee =
                new Employee("first", "employer", 20000, "first@TW.com") {SecondEmail = "second@TW2.com"};
            string secondEmailPrefix = employee.GetSecondEmailPrefix();
            Assert.Equal("second", secondEmailPrefix);
        }

        [Fact]
        public void should_get_second_email_postfix()
        {
            Employee employee =
                new Employee("first", "employer", 20000, "first@TW.com") {SecondEmail = "second@TW2.com"};
            string secondEmailPostfix = employee.GetSecondEmailPostfix();
            Assert.Equal("TW2.com", secondEmailPostfix);
        }
    }
}
