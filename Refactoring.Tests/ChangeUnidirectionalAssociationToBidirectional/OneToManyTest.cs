using System.Linq;
using Refactoring.ChangeUnidirectionalAssociationToBidirectional;
using Xunit;

namespace Refactoring.Tests.ChangeUnidirectionalAssociationToBidirectional
{
    public class OneToManyTest
    {
        [Fact]
        public void should_get_company_from_employee()
        {
            var employee = new Engagement {Client = new Client("Hasting")};
            Assert.Equal("Hasting", employee.Client.name);
        }

        [Fact]
        public void should_get_employee_from_company()
        {
            var company = new Client("IBM");
            var employee = new Engagement() {Client = company};
            var employee2 = new Engagement() { Client = company};
            Assert.Equal(2, company.Engagements.Count());
        }
    }
}
