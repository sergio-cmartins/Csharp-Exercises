using System;
using System.Globalization;
using System.Collections.Generic;
using EmployeeListControl.Entities;


namespace EmployeeListControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int numberEmployees = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberEmployees; i++)
            {
                Console.WriteLine("Employee #{0}:",i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());
            Employee filteredEmployee = employees.Find(x => x.Id == employeeId);

            if (filteredEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                filteredEmployee.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("\nUpdated list of employees: ");
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
