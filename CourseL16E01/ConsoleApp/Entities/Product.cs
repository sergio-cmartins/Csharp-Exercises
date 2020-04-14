using System.Globalization;

namespace ConsoleApp.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Used { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            Used = false;
        }

        public Product(string name, double price, bool used) : this(name, price)
        {
            Used = used;
        }

        public override string ToString()
        {
            string isUsed = Used == true ? " (Used)" : "";
            return Name + isUsed + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
