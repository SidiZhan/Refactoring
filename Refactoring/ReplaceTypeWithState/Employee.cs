using System;

namespace Refactoring.ReplaceTypeWithState
{
    public class Employee
    {
        EmployeeType EmployeeType { get; set; }


        public void SetType(int value)
        {
            EmployeeType = EmployeeType.Create(value);
        }

        public Employee(int type)
        {
            SetType(type);
        }

        public int GetPayroll()
        {
            return EmployeeType.GetPayroll();
        }
    }

     class InvalidEngineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            throw new ArgumentException();
        }

        public override int GetPayroll()
        {
            throw new ArgumentException("Incorrect Employee");
        }
    }

    abstract class EmployeeType
    {
        internal const int ENGINEER = 0;
        internal const int SALESMAN = 1;
        internal const int MANAGER = 2;

        internal const int baseSalary = 3000;
        internal const int commission = 20000;
        internal const int bonus = 500000;

        public static EmployeeType Create(int type)
        {
            switch (type)
            {
                case ENGINEER:
                    return new Engineer();
                case SALESMAN:
                    return new Salesman();
                case MANAGER:
                    return new Manager();
                default:
                    return new InvalidEngineer();
            }
        }

        public abstract int GetTypeCode();
        public abstract int GetPayroll();
    }


    class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return ENGINEER;
        }

        public override int GetPayroll()
        {
            return baseSalary;
        }
    }

    class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return SALESMAN;
        }

        public override int GetPayroll()
        {
            return baseSalary + commission;
        }
    }

    class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return MANAGER;
        }

        public override int GetPayroll()
        {
            return baseSalary + bonus;
        }
    }

}
