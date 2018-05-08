namespace Refactoring.ReplaceConditionalWithPolymorphism
{
    public class Manager : EmployeeStrategy
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.MANAGER;
        }
    }
}
