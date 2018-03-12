namespace Refactoring.IntroduceForeignMethod
{
    #region I'm a third party library

    public class Username
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Username()
        {
        }

        public Username(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
    }

    #endregion
}