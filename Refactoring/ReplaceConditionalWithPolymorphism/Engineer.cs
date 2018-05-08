namespace Refactoring.ReplaceConditionalWithPolymorphism
{
    public class Engineer : EmployeeStrategy
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.ENGINEER;
        }
    }
}
