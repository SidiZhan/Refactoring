namespace Refactoring.IntroduceNullObject
{
    public class Customer
    {
        readonly string Name;
        readonly BillingPlan Plan;
        readonly PaymentHistory PaymentHistory;

        public Customer(PaymentHistory paymentHistory, BillingPlan plan, string name)
        {
            PaymentHistory = paymentHistory;
            Plan = plan;
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public BillingPlan GetPlan()
        {
            return Plan;
        }

        public PaymentHistory GetHistory()
        {
            return PaymentHistory;
        }

    }
}