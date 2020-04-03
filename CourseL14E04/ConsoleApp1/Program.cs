using System;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instantiating several diferent devices!");

            //We cannot use upcast as a device since the SuperClass don't have the devinition of scan and print interfaces
            Scanner scanner = new Scanner("1scan001a");
            scanner.ProcessDoc("HelloWorld.txt");
            Console.WriteLine(scanner.Scan());

            Printer printer = new Printer("1print002a");
            printer.ProcessDoc("HelloWorld.txt");
            printer.Print("HelloWorld.txt");

            ComboDevice comboDevice = new ComboDevice("1comb003a");
            comboDevice.ProcessDoc("HelloWorld.txt");
            comboDevice.Print("HelloWorld.txt");
            Console.WriteLine(comboDevice.Scan());


        }
    }
}
