namespace ConsoleApp1.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }

        protected Device(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        abstract public void ProcessDoc(string Doc);
    }
}
