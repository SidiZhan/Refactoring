using Refactoring.IntroduceNullObject;
using Xunit;

namespace Refactoring.Tests.IntroduceNullObject
{
    public class CalSiteInfoFact
    {
        [Fact]
        public void should_return_customer_info_when_customer_not_null()
        {
            var customerName = "YanPei";
            var plan = new BillingPlan(3000);
            var customer = new Customer(new PaymentHistory(), plan, customerName);
            var site = new Site(customer);
            var calSiteInfo = new CalSiteInfo(site);

            Assert.Equal(customerName, calSiteInfo.GetCustomerInfo());
            Assert.Equal(2, calSiteInfo.GetWeeksDelinquent());
            Assert.Equal(3000, calSiteInfo.GetBillingPlan().Rent);
        }

        [Fact]
        public void should_return_default_customer_info_when_customer_be_null()
        {
            var site = new Site(null);
            var calSiteInfo = new CalSiteInfo(site);

            Assert.Equal("CustomDefaultName", calSiteInfo.GetCustomerInfo());
            Assert.Equal(0, calSiteInfo.GetWeeksDelinquent());
            Assert.Equal(0, calSiteInfo.GetBillingPlan().Rent);
        }
    }

}
