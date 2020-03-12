using System;
using System.Collections.Generic;

namespace HashSetExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing all hashsets
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            HashSet<int> allStudents = new HashSet<int>();

            //Read students from the Three Courses
            Console.Write("How Many Students in Course 'A'? ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the students IDs for Course 'A':");
            for (int i = 0; i < x; i++)
            {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nHow Many Students in Course 'B'? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the students IDs for Course 'B':");
            for (int i = 0; i < x; i++)
            {
                courseB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("\nHow Many Students in Course 'C'? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the students IDs for Course 'C':");
            for (int i = 0; i < x; i++)
            {
                courseC.Add(int.Parse(Console.ReadLine()));
            }

            //Create a resulting HashSet with all students
            allStudents.UnionWith(courseA);
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            //Display the number of unique students
            Console.WriteLine("\n\nTotal of students: " + allStudents.Count);
        }
    }
}
