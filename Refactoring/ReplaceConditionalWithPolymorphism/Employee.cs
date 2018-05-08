using System;

namespace Refactoring.ReplaceConditionalWithPolymorphism
{
    public class Employee
    {
        const int _monthlySalary = 1000;
        const int _commission = 100;
        const int _bonus = 10;

        readonly EmployeeStrategy strategy;

        public Employee(EmployeeType type)
        {
            strategy = GetStrategy(type);
        }

        public int GetAmount()
        {
            switch (strategy.GetEmployeeType())
            {
                case EmployeeType.ENGINEER:
                    return _monthlySalary;
                case EmployeeType.SALESMAN:
                    return _monthlySalary + _commission;
                case EmployeeType.MANAGER:
                    return _monthlySalary + _bonus;
                default:
                    throw new NotSupportedException();
            }
        }

        static EmployeeStrategy GetStrategy(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.ENGINEER:
                    return new Engineer();
                case EmployeeType.SALESMAN:
                    return new Salesman();
                case EmployeeType.MANAGER:
                    return new Manager();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
