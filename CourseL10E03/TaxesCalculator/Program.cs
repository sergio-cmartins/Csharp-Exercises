using System;
using System.Globalization;
using System.Collections.Generic;
using TaxesCalculator.Entities;

namespace TaxesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ic == 'i' || ic == 'I' )
                {
                    Console.Write("Health expenditures: ");
                    double medicalExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new NaturalPerson(name, annualIncome, medicalExpenses));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXESPAID:");
            double totalTaxes = 0.0;
            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                totalTaxes += taxPayer.Tax();
            }
            Console.WriteLine("\nTOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
