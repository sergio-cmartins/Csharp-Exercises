using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computers", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>(){
                new Product(01, "Computer", 1100.00, c2),
                new Product(02, "Hammer", 50.00, c1),
                new Product(03, "TV", 1700.00, c3),
                new Product(04, "Notebook", 1300.00, c2),
                new Product(05, "Saw", 80.00, c1),
                new Product(06, "Tablet", 700.00, c2),
                new Product(07, "Camera", 700.00, c3),
                new Product(08, "Printer", 350.00, c3),
                new Product(09, "Macbook", 1800.00, c2),
                new Product(10, "Sound Bar", 700.00, c3),
                new Product(11, "Level", 70.00, c1),
                new Product(12, "Tweezers", 50.00, c1)
            };

            var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            Print("Tier1 and Price < 900.00:", r1);

            var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("Name of products with category = Tools", r2);

            var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name }); //use of an anonimous object
            Print("Name, Price And category of products with name stating with C", r3);

            var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Products of Tier 1, ordered by price and name", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Skip 2 and take 4 items from the previous result", r5);

            Console.WriteLine();
            var r6 = products.FirstOrDefault();
            Console.WriteLine("Teste First or Default, with valid result: " + r6);
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("Teste First or Default, with non valid result: " + r7);

            Console.WriteLine();
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Teste Single or Default, with valid result: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Teste Single or Default, with non valid result: " + r9);

            Console.WriteLine();
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Finding the Maximum Price of any product: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Finding the Minimum Price of any product: " + r11);
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Total Price of Category 1 items: " + r12);
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Average Price of Category 1 items: " + r13);
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average Price of Category 5 items with default if not exists: " + r14);
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (ac, x) => ac + x);
            Console.WriteLine("Total Price of Category 1 items using aggregate function: " + r15);

            Console.WriteLine();
            var r16 = products.GroupBy(g => g.Category);
            foreach (IGrouping<Category,Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)       
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            var r20 = products.Where(p => p.Price == products.Max(x => x.Price));
            Print("Product(s) with the highest Price", r20);
            var r21 = products.Where(p => p.Price == products.Min(x => x.Price));
            Print("Product(s) with the lowest Price", r21);
        }
    }
}
