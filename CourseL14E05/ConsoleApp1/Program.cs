using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"E:\trf\employees.csv";

            try
            {
                using( StreamReader sr = File.OpenText(file))
                {
                    List<Employee> employees = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double salary = double.Parse(line[1], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, salary));
                    }

                    employees.Sort();
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine(employee);
                    }

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred:");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
