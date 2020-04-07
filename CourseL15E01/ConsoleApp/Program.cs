using System;
using ConsoleApp.Extensions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a valid date to calculate the elapsed time (type an invalid date to end the program)");
            try
            {
                while (true)
                {
                    Console.Write("Type a valid date => ");
                    DateTime dt = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Date Typed: " + dt);
                    Console.WriteLine("Elapsed Time: " + dt.ElapsedTime());
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nProcesso Concluido!");
            }
        }
    }
}
