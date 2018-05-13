using System;

namespace Refactoring.PreserveWholeObject
{
    public class HireAnniversaryEmailJob
    {
        public void Execute()
        {
            var anniversaryEmployee = GetAnniversaryEmployee();
            int hiredYear = DateTime.Now.Year - anniversaryEmployee.HireDate.Year;
            SendAnniversaryEmail(anniversaryEmployee, hiredYear);
        }

        public Mail SendAnniversaryEmail(Employee employee, int hiredYear)
        {
            return new Mail
            {
                From = "system",
                To = employee.Email,
                Title = employee.GetFullName(),
                Content = $"This is the {hiredYear}th years"
            };
        }

        public Employee GetAnniversaryEmployee()
        {
            return new Employee
            {
                Id = 1,
                FirstName = "first",
                LastName = "last",
                Birthday = DateTime.Now,
                Email = "email@birthday.com",
                HireDate = DateTime.Now.AddYears(-1)
            };
        }
    }


}