using Refactoring.ReplaceErrorCodeWithException;
using Xunit;

namespace Refactoring.Tests.ReplaceErrorCodeWithException
{
    public class ReplaceErrorCodeWithExceptionFact
    {
        [Fact]
        public void Withdraw_money_from_account()
        {
            var account = new Account(1000);
            var user = new User(account);

            user.Withdraw(100);

            Assert.Equal(900, user.CheckAccountBalance());
        }


        [Fact]
        public void Withdraw_money_from_account_overdrawn()
        {
            var account = new Account(1000);
            var user = new User(account);

            user.Withdraw(1100);

            Assert.Equal(1000, user.CheckAccountBalance());
        }
    }
}
