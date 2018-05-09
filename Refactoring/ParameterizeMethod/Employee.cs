using System;

namespace Refactoring.ParameterizeMethod
{
    public enum EmployeeType
    {
        ENGINEER = 0,
        SALESMAN = 1,
        MANAGER = 2
    }

    public class Employee
    {
        internal double baseSalary = 3000;
        internal const int commission = 20000;
        internal const int bonus = 500000;

        public static Employee Create(EmployeeType type)
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
                    throw new ArgumentException("Incorrect type code value");
            }
        }

        public virtual double GetPayroll()
        {
            throw new NotSupportedException();
        }

        public void twentyPercentRaise() { baseSalary *= 1.2; }

        public void fivePercentRaise() { baseSalary *= 1.05; }
    }

    class Engineer : Employee
    {
        public override double GetPayroll()
        {
            return baseSalary;
        }
    }

    class Salesman : Employee
    {
        public override double GetPayroll()
        {
            return baseSalary + commission;
        }
    }

    class Manager : Employee
    {
        public override double GetPayroll()
        {
            return baseSalary + bonus;
        }
    }

}
