using System;
using System.Globalization;
using CourseL04E05.Entities;

namespace CourseL04E05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Student Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Type de Studend three grades: ");
            student.Grade01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Final Grade: " + student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture));
            if (student.Approved())
            {
                Console.WriteLine("APPROVED");
            }
            else
            {
                Console.WriteLine("DISAPPROVED");
                Console.WriteLine("MISSING " 
                                + student.MissingGrade().ToString("F2", CultureInfo.InvariantCulture) 
                                + " POINTS");
            }
        }
    }
}
