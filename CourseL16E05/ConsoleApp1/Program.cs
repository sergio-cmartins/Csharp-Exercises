using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the Full File Path: ");
            string file = Console.ReadLine();
            using StreamReader sr = File.OpenText(@file);
            while (!sr.EndOfStream)
            {
                string[] fields = sr.ReadLine().Split(',');
                products.Add(new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture)));
            }

            /* Simple Solution
            double avgPrice = products.Average(p => p.Price);
            var result = products.Where(p => p.Price <= avgPrice).OrderByDescending(p => p.Name).Select(p => p.Name);
            */

            // protecting in case the list was empty and using alternative query notation for Linq
            double avgPrice = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var result =
                from p in products
                where p.Price <= avgPrice
                orderby p.Name descending
                select p.Name;

            Console.WriteLine("Average price: " + avgPrice.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
        }
    }
}
