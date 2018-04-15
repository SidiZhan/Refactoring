namespace Refactoring.IntroduceNullObject
{
    public class BillingPlan
    {
        public int Rent;

        public BillingPlan(int rent)
        {
            Rent = rent;
        }

        public static BillingPlan BasicPlan()
        {
            return new BillingPlan(0);
        }
    }
}