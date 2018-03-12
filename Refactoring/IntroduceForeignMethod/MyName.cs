namespace Refactoring.IntroduceForeignMethod
{
    public class MyName
    {
        readonly Username _username;

        public MyName(string firstName, string middleName, string lastName)
        {
            _username = new Username(firstName, middleName, lastName);
        }

        public string GetFullName()
        {
            return $"{_username.LastName}, {_username.FirstName} {_username.MiddleName}";
        }
    }
}