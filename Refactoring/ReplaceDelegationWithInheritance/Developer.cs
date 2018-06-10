namespace Refactoring.ReplaceDelegationWithInheritance
{
    public class Developer
    {
        readonly Employee _employee;

        public Developer(string name, Gender gender)
        {
            _employee = new Employee
            {
                Name = name,
                Gender = gender
            };
        }

        public string Name => _employee.Name;

        public Gender Gender => _employee.Gender;
    }

    class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
