namespace Refactoring.ReplaceErrorCodeWithException
{
    public class User
    {
        readonly Account account;

        public User(Account account)
        {
            this.account = account;
        }

        public double Withdraw(double amount)
        {
            var withdrawCode = account.Withdraw(amount);
            if (withdrawCode == -1)
            {
                HandleOverDrawn();
                return 0;
            }

            DoSomething();
            return amount;
        }

        public double CheckAccountBalance()
        {
            return account.Balance;
        }

        void DoSomething()
        {
        }

        void HandleOverDrawn()
        {
        }
    }

    public class Account
    {
        public double Balance { get; private set; }

        public Account(double balance)
        {
            Balance = balance;
        }

        public int Withdraw(double amount)
        {
            if (amount > Balance)
            {
                return -1;
            }

            Balance -= amount;
            return 0;
        }
    }
}
