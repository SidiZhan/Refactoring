namespace Refactoring.ReplaceConditionalWithPolymorphism
{
    public class Salesman : EmployeeStrategy
    {
        public override EmployeeType GetEmployeeType()
        {
            return EmployeeType.SALESMAN;
        }
    }
}
