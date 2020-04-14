using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Entities;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("A simple program with various types of delegates.");

            //building the sample list of products
            products.Add(new Product("Iphone 6", 2500.00));
            products.Add(new Product("Iphone 6", 1900.00, true));
            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));
            products.Add(new Product("Mechanical Keyboard", 200.00));
            products.Add(new Product("Mechanical Keyboard", 250.00, true));

            Console.WriteLine("Example of sorting using the delegate Comparison<T>");
            Console.WriteLine("\n1 - Ascending sorting by name:"  );
            //Using a lambda (anonimous) function call
            products.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            //Using a function reference to the Action<in T> delegate
            products.ForEach(PrintProduct);

            Console.WriteLine("\n2 - Reverse sorting the list:");
            //Calling a function references that matches the delegate Comparison<in T>
            products.Sort(RevCompare);
            //Using a function reference to the Action<in T> delegate
            products.ForEach(PrintProduct);

            Console.WriteLine("\n3 - Sort Used First then by name:");
            // Showing that you can assign a function reference to and variable of the type of the delegate
            Comparison<Product> twoLvl = TwoLevelCompare; 
            products.Sort(twoLvl);
            //Using a function reference to the Action<in T> delegate
            products.ForEach(PrintProduct);

            Console.WriteLine("\n4 - Removing Product with price lower than 200.00");
            // Showing use of the delegate Predicate<in T>
            products.RemoveAll(RemoveLowerPrice);
            //Using a function reference to the Action<in T> delegate
            products.ForEach(PrintProduct);

            Console.WriteLine("\n5 - Reducing the price by 10% of products with price above 1000.00");
            //Showing use of the delegate Action<in T> with void returning lambda expressions
            products.ForEach(p => { p.Price *= (p.Price >= 1000.00) ? 0.90 : 1.00; });
            //Using a function reference to the delegate Action<in T>
            products.ForEach(PrintProduct);

            Console.WriteLine("\n6 - returning a string list with uppercase product names");
            //Showing the use of the delegate Func<in T, out TResult> with a lamba expression
            Func<Product, String> UpperList = p => p.Name.ToUpper();
            List<String> UpperCaseProducts = products.Select(UpperList).ToList();
            foreach (string item in UpperCaseProducts)
            {
                Console.WriteLine(item);
            }
            
        }

        static int RevCompare(Product p1, Product p2)
        {
            return p2.Name.CompareTo(p1.Name);
        }

        static int TwoLevelCompare(Product p1, Product p2)
        {
            int compUsed = p2.Used.CompareTo(p1.Used);
            if (compUsed == 0)
            {
                return p1.Name.CompareTo(p2.Name);
            }
            else
            {
                return compUsed;
            }
        }

        static bool RemoveLowerPrice(Product p1) {
            return p1.Price <= 200.00;
        }

        static void PrintProduct(Product p1)
        {
            Console.WriteLine(p1);
        }



    }

}
