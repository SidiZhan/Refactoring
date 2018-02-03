using Refactoring.Libs;

namespace Refactoring.IntroduceLocalExtension
{
    public class MyUser
    {
        public string GetFullName(string firstName, string middleName, string lastName)
        {
            var username = new Username(firstName, middleName, lastName);
            return $"{username.FirstName}, {username.FirstName} {username.MiddleName}";
        }
    }
}