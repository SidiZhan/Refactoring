namespace Refactoring.IntroduceNullObject
{
    public class CalSiteInfo
    {
        readonly Site _site;

        public CalSiteInfo(Site site)
        {
            _site = site;
        }

        public string GetCustomerInfo()
        {
            var customer = _site.GetCustomer();
            return customer == null ? "CustomDefaultName" : customer.GetName();
        }

        public int GetWeeksDelinquent()
        {
            var customer = _site.GetCustomer();
            return customer?.GetHistory().GetWeeksDelinquentInLastYear() ?? 0;
        }

        public BillingPlan GetBillingPlan()
        {
            var customer = _site.GetCustomer();
            return customer == null ? BillingPlan.BasicPlan() : customer.GetPlan();
        }
    }
}
