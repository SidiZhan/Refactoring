using System;
using Refactoring.ParameterizeMethod;
using Xunit;

namespace Refactoring.Tests.ParameterizeMethod
{
    public class EmployeeFact
    {
        [Fact]
        void should_get_employee_payroll_for_engineer()
        {
            var engineer = Employee.Create(EmployeeType.ENGINEER);
            Assert.Equal(3000, engineer.GetPayroll());
        }

        [Fact]
        void should_get_employee_payroll_for_salesman()
        {
            var salesman = Employee.Create(EmployeeType.SALESMAN);
            Assert.Equal(23000, salesman.GetPayroll());
        }

        [Fact]
        void should_get_employee_payroll_for_manager()
        {
            var manager = Employee.Create(EmployeeType.MANAGER);
            Assert.Equal(503000, manager.GetPayroll());
        }

        [Fact]
        void should_raise_ten_percent_salary()
        {
            var engineer = Employee.Create(EmployeeType.ENGINEER);

            Assert.Equal(3000, engineer.GetPayroll());
            engineer.twentyPercentRaise();
            Assert.Equal(3600, engineer.GetPayroll());
        }

        [Fact]
        void should_raise_five_percent_salary()
        {
            var engineer = Employee.Create(EmployeeType.ENGINEER);

            Assert.Equal(3000, engineer.GetPayroll());
            engineer.fivePercentRaise();
            Assert.Equal(3150, engineer.GetPayroll());
        }
    }
}
