using System;
using System.IO;
using System.Globalization;
using ProcessProductsCSV.Entities;

namespace ProcessProductsCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please inform the source file with full path: ");
            string sourceFile = Console.ReadLine();

            try
            {
                string outpath = Path.GetDirectoryName(sourceFile) + Path.DirectorySeparatorChar + "out";
                string outfile = outpath + Path.DirectorySeparatorChar + "summary.csv";

                Directory.CreateDirectory(outpath);

                using (StreamReader sr = File.OpenText(sourceFile))
                {
                    using (StreamWriter sw = File.CreateText(outfile))
                    {
                        while (!sr.EndOfStream){
                            string[] fields = sr.ReadLine().Split(',');
                            Product p = new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));
                            sw.WriteLine(p.Name + "," + p.Total.ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }

            } catch (IOException e)
            {
                Console.WriteLine("An error occured during execution:");
                Console.WriteLine(e.Message);
            }

        }
    }
}
