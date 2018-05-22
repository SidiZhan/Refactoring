using System;
using System.Diagnostics;

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
            if (!account.CanWithdraw(amount))
            {
                HandleOverDrawn();
                return 0;
            }
            account.Withdraw(amount);
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

        public void Withdraw(double amount)
        {
            Debug.Assert(amount <= Balance);
            Balance -= amount;
        }

        public bool CanWithdraw(double amount)
        {
            return Balance >= amount;
        }
    }
}
