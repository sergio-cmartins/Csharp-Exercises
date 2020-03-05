using System.Globalization;

namespace BankAccount.Entities
{
    class Account
    {
        private double withdrawalTax = 5.00;

        public int AccNumber { get; private set; }
        public string OwnerName { get; set; }
        public double Balance { get; private set; }

        public Account(int accNumber, string ownerName)
        {
            AccNumber = accNumber;
            OwnerName = ownerName;
        }

        public Account(int accNumber, string ownerName, double initialDeposit) : this(accNumber, ownerName)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= (amount + withdrawalTax);
        }

        public override string ToString()
        {
            return "Account "
                 + AccNumber
                 + ", Account Owner: "
                 + OwnerName
                 + ", Balance: $ "
                 + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
