using System;

namespace Refactoring.ReplaceDataValueWithObject
{
    public class Employee
    {
        public string Name { get; }
        public string Employer { get; }
        public long Salary { get; }
        public string PrimaryEmail { get; set;}
        public string SecondEmail { get; set; }
        public string DateOfBirth { get; set; }


        public Employee(string name, string employer, long salary, string primaryEmail)
        {
            Name = name;
            Employer = employer;
            Salary = salary;
            PrimaryEmail = primaryEmail;
        }

        public string GetPrimaryEmailPrefix()
        {
            return GetEmailPrefix(PrimaryEmail);
        }

        public string GetPrimaryEmailPostfix()
        {
            return GetEmailPostfix(PrimaryEmail);
        }

        public string GetCompanyInfoFromPrimaryEmail()
        {
            var domain = PrimaryEmail.Substring(PrimaryEmail.IndexOf("@", StringComparison.Ordinal) + 1);
            if (domain.Contains("."))
            {
                return domain.Substring(0, domain.IndexOf(".", StringComparison.Ordinal));
            }
            return domain;
        }

        string GetEmailPrefix(string email)
        {
            return email.Substring(0, email.IndexOf("@", StringComparison.Ordinal));
        }

        public string GetSecondEmailPrefix()
        {
            return GetEmailPrefix(SecondEmail);
        }

        public string GetSecondEmailPostfix()
        {
            return GetEmailPostfix(SecondEmail);
        }

        string GetEmailPostfix(string email)
        {
            return email.Substring(email.IndexOf("@", StringComparison.Ordinal) + 1);
        }
    }
}
