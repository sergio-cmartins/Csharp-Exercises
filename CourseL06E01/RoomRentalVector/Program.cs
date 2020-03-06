using System;
using RoomRentalVector.Entities;

namespace RoomRentalVector
{
    class Program
    {
        static void Main(string[] args)
        {
            Lodger[] lodgers = new Lodger[10];

            Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rooms; i++)
            {
                Console.WriteLine("\nRent #{0}:", i);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                lodgers[room] = new Lodger(name, email);
            }

            Console.WriteLine("\nOccupied rooms:");
            for (int i = 0; i < 9; i++)
            {
                if (lodgers[i]!=null)
                {
                    Console.WriteLine("{0}: {1}",i,lodgers[i]);
                }
            }
        }
    }
}
