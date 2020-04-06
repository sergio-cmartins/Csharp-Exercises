using System;
using System.Globalization;

namespace ConsoleApp1.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Name
                + ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing Error: argument is not an Employee object");
            }
            Employee other = obj as Employee;
            if (Salary.CompareTo(other.Salary) !=0)
            {
                return Salary.CompareTo(other.Salary);
            }
            else
            {
                return Name.CompareTo(other.Name);
            }
            
        }
    }
}
