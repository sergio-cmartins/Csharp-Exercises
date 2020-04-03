using System;
using System.Globalization;
using ContractsInstallments.Entities;
using ContractsInstallments.Services;

namespace ContractsInstallments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, totalValue);
            
            //Service to fill installments
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            //Present the result on Screen
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
