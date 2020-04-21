using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Define the Data Source
            //using a simple file to list but can be any data source
            List<string> dsList = File.ReadAllLines(@"E:\trf\stringList.txt").ToList<string>();

            //Define the Query expression
            // In this example I'm searching(where) all names begining with D and converting them to uppercase(select).
            var result = dsList
                .Where(p => p.Substring(0, 1) == "D")
                .Select(r => r.ToUpper())
                .ToList();

            //Console.WriteLine("Hello World!");
            result.ForEach(p => { Console.WriteLine(p); });
        }
    }
}
