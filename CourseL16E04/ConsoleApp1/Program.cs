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

            //Refactoring some consult showing query notation
            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            var r1 =
                from x in products
                where x.Category.Tier == 1 && x.Price < 900.0
                select x;
            Print("Tier1 and Price < 900.00:", r1);

            //var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            var r2 =
                from x in products
                where x.Category.Name == "Tools"
                select x.Name;
            Print("Name of products with category = Tools", r2);

            //var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name }); //use of an anonimous object
            var r3 =
                from x in products
                where x.Name[0] == 'C'
                select new { x.Name, x.Price, CategoryName = x.Category.Name };
            Print("Name, Price And category of products with name stating with C", r3);

            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from x in products
                where x.Category.Tier == 1
                orderby x.Price, x.Name
                select x;
            Print("Products of Tier 1, ordered by price and name", r4);

            //var r5 = r4.Skip(2).Take(4); 
            // Putting the full query just to show how to use these functions with query notation
            var r5 =
                (from x in products
                 where x.Category.Tier == 1
                 orderby x.Price, x.Name
                 select x)
                .Skip(2)
                .Take(4);
            Print("Skip 2 and take 4 items from the query (query similar as previous result)", r5);

            Console.WriteLine();
            //var r16 = products.GroupBy(g => g.Category);
            var r16 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
