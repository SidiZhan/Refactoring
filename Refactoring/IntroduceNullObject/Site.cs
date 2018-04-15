namespace Refactoring.IntroduceNullObject
{
    public class Site
    {
        readonly Customer _customer;

        public Site(Customer customer)
        {
            _customer = customer;
        }

        public Customer GetCustomer()
        {
            return _customer;
        }
    }
}
