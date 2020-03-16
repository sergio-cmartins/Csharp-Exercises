using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OrderManagement.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public OrderItem(int quantity, double price, Product product) : this(quantity, product)
        {
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity
                + ", SubTotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
