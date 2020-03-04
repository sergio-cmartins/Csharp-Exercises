using System;
using System.Globalization;
using CourseL04E04.Entities;

namespace CourseL04E04
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.Write("Name: ");
            employee.Name = Console.ReadLine();
            Console.Write("Gross Pay: ");
            employee.GrossPay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Tax: ");
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nEmployee: " + employee);
            Console.Write("\nType the percentare to raise the salary: ");
            employee.RaiseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("\nUpdated Data: " + employee);

        }
    }
}
