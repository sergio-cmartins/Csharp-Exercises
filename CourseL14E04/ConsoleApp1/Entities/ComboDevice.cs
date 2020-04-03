using System;
namespace ConsoleApp1.Entities
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public ComboDevice(string serialNumber) : base(serialNumber) { }

        public void Print(string doc)
        {
            Console.WriteLine("ComboDevice printing document: " + doc);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("ComboDevice processing document:" + doc);
        }

        public string Scan()
        {
            return "Information Scanned on ComboDevice: loren ipsun";
        }
    }
}
