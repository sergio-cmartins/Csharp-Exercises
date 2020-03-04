using System;
using System.Globalization;
using CourseL04E02.Entities;

namespace CourseL04E02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("First employee data: ");
            Console.Write("Name: ");
            e1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Second employee data: ");
            Console.Write("Name: ");
            e2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            e2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double avgSalary = (e1.Salary + e2.Salary) / 2.0;
            Console.WriteLine("Average Salary: " + avgSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
