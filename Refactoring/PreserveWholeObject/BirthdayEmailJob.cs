using System;
using System.Collections.Generic;

namespace Refactoring.PreserveWholeObject
{
    public class BirthdayEmailJob
    {
        public void Execute()
        {
            var birthdayEmployee = GetBirthdayEmployee();
            SendBirthdayEmail(birthdayEmployee.FirstName, birthdayEmployee.LastName, birthdayEmployee.Email);
        }

        public Mail SendBirthdayEmail(string firstName, string lastName, string email)
        {
            return new Mail
            {
                From = "system",
                To = email,
                Title = $"{lastName}, {firstName}",
                Content = "Happy Birthday"
            };
        }

        public Employee GetBirthdayEmployee()
        {
            return new Employee
            {
                Id = 1,
                FirstName = "first",
                LastName = "last",
                Birthday = DateTime.Now,
                Email = "email@birthday.com",
                HireDate = DateTime.Now
            };
        }
    }
}