using System;
using System.Globalization;
using BankAccount.Entities;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account;

            Console.Write("Enter the account number: ");
            int accNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Account Owner: ");
            string accOwner = Console.ReadLine();
            Console.Write("Make Initial Deposit (y/n)? ");
            char response = char.Parse(Console.ReadLine());
            if (response == 'y' || response == 'Y')
            {
                Console.Write("Enter the Deposit Amount: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account = new Account(accNumber, accOwner, initialDeposit);
            }
            else
            {
                account = new Account(accNumber, accOwner);
            }

            Console.WriteLine("\nAccount data:");
            Console.WriteLine(account);

            Console.Write("\nEnter a deposit amount: ");
            account.Deposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Uppdated account data:");
            Console.WriteLine(account);

            Console.Write("\nEnter a withdrawal amount: ");
            account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Uppdated account data:");
            Console.WriteLine(account);

        }
    }
}
