using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Printer : Device, IPrinter
    {


        public Printer(string serialNumber) : base(serialNumber) { }

        public void Print(string doc)
        {
            Console.WriteLine("Printing document: " + doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer Processing document: " + doc);
        }
    }
}
