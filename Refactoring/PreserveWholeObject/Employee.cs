using System;

namespace Refactoring.PreserveWholeObject
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime HireDate { get; set; }

        public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }
}