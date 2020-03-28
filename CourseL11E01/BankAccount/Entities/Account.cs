using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            Balance = 0.0;

            //Adds the balance as initial Deposit
            Deposit(balance);

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance.");
            }
            Balance -= amount;
        }
    }
}
