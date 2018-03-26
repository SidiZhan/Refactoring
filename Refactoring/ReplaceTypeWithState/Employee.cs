using System;

namespace Refactoring.ReplaceTypeWithState
{
    public class Employee
    {
        const int baseSalary = 3000;
        const int commission = 20000;
        const int bonus = 500000;

        const int ENGINEER = 0;
        const int SALESMAN = 1;
        const int MANAGER = 2;

        public int Type { get; set; }

        public Employee(int type)
        {
            Type = type;
        }


        public int GetPayroll()
        {
            switch (Type)
            {
                case ENGINEER:
                    return baseSalary;
                case SALESMAN:
                    return baseSalary + commission;
                case MANAGER:
                    return baseSalary + bonus;
                default:
                    throw new ArgumentException("Incorecct Employee");
            }
        }
    }
}
