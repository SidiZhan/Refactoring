using System;
using Refactoring.ReplaceTypeWithState;
using Xunit;

namespace Refactoring.Tests.ReplaceTypeCodeWithState
{
    public class EmployeeFact
    {
        [Fact]
        void should_get_employee_payroll_for_engineer()
        {
            var engineer = new Employee(0);
            Assert.Equal(3000, engineer.GetPayroll());

            engineer.SetType(2);
            Assert.Equal(503000, engineer.GetPayroll());
        }

        [Fact]
        void should_get_employee_payroll_for_salesman()
        {
            var salesman = new Employee(1);
            Assert.Equal(23000, salesman.GetPayroll());
        }

        [Fact]
        void should_get_employee_payroll_for_manager()
        {
            var manager = new Employee(2);
            Assert.Equal(503000, manager.GetPayroll());
        }

        [Fact]
        void should_throw_ArgumentException_when_get_payroll_for_incorrect_employee()
        {
            var employee = new Employee(3);
            Assert.Equal("Incorrect Employee", Assert.Throws<ArgumentException>(() => employee.GetPayroll()).Message);
        }
    }
}
