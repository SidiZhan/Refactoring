using Refactoring.ReplaceConditionalWithPolymorphism;
using Xunit;

namespace Refactoring.Tests.ReplaceConditionalWithPolymorphism
{
    public class EmployeeFacts
    {
        [Fact]
        void should_get_amount_for_engineer()
        {
            Assert.Equal(1000, new Employee(EmployeeType.ENGINEER).GetAmount());
        }

        [Fact]
        void should_get_amount_for_salesman()
        {
            Assert.Equal(1100, new Employee(EmployeeType.SALESMAN).GetAmount());
        }
        
        [Fact]
        void should_get_amount_for_manager()
        {
            Assert.Equal(1010, new Employee(EmployeeType.MANAGER).GetAmount());
        }
    }
}
