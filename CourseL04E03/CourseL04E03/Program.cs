using System;
using System.Globalization;
using CourseL04E03.Entities;

namespace CourseL04E03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangle R = new Retangle();

            Console.WriteLine("Enter the Height and Width of the retangle");
            R.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Area: " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter: " + R.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
