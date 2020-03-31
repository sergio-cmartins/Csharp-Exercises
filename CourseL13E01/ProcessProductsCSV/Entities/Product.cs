using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessProductsCSV.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total
        {
            get { return Price * Quantity; }
        }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
