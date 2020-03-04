using System;
using System.Globalization;
using CourseL04E01.Entities;

namespace CourseL04E01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("First Person Data:");
            Console.Write("Name: ");
            p1.Name = Console.ReadLine();
            Console.Write("Age: ");
            p1.Age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Second Person Data:");
            Console.Write("Name: ");
            p2.Name = Console.ReadLine();
            Console.Write("Age: ");
            p2.Age = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Older person: ");
            if (p1.Age > p2.Age)
            {
                Console.WriteLine(p1.Name);
            }
            else
            {
                Console.WriteLine(p2.Name);
            }
        }
    }
}
