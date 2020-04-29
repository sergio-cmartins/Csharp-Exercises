using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            //Loading the File and Filling the internal List
            Console.Write("Enter full file path: ");
            string inputFile = Console.ReadLine();
            using StreamReader sr = File.OpenText(inputFile);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                employees.Add(new Employee(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture)));
            }
            Console.WriteLine("List Loaded!\n");
            //Searching of employees with Salary greater than the informed by the user
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var emails = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            //Calc the Sum of Salaries
            double sum = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.Write("\nSum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
