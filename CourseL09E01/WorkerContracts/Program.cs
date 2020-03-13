using System;
using System.Globalization;
using WorkerContracts.Entities;
using WorkerContracts.Entities.Enums;

namespace WorkerContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker Basic Data
            Console.Write("Enter department's name: ");
            Department department = new Department(Console.ReadLine());
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, level, baseSalary, department);

            //Contract Data for the worker
            Console.Write("How many contracts for this worker? ");
            int nroContracts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nroContracts; i++)
            {
                Console.WriteLine("Enter #{0} contract data:", i);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                worker.AddContract(new HourContract(date, valuePerHour, hours));
            }

            //Income Calculation and information Display
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string input = Console.ReadLine();
            int month = int.Parse(input.Split('/')[0]);
            int year = int.Parse(input.Split('/')[1]);
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department);
            Console.WriteLine("Income for " + input + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
