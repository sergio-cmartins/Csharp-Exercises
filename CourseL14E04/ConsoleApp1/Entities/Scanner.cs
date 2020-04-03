using System;
namespace ConsoleApp1.Entities
{
    class Scanner : Device, IScanner
    {
        public Scanner(string serialNumber) : base(serialNumber) { }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner Processing Document: " + doc);
        }

        public string Scan()
        {
            return "Result of scan: loren ipsun";
        }
    }
}
