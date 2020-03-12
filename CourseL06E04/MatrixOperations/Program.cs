using System;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type the array dimensions: ");
            string input = Console.ReadLine();
            int lines = int.Parse(input.Split(' ')[0]);
            int columns = int.Parse(input.Split(' ')[1]);
            int[,] array = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                Console.Write("Enter the {0} values for line #{1}: ",columns,i+1);
                string[] lineInput = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = int.Parse(lineInput[j]);
                }
            }
            Console.Write("\nEnter the number to Search for: ");
            int pesq = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i,j] == pesq)
                    {
                        Console.WriteLine("Position {0},{1}: ",i,j);
                        if (j > 0) { Console.WriteLine("Left: " + array[i, j - 1]); }
                        if (j < columns - 1) { Console.WriteLine("Right: " + array[i, j + 1]); }
                        if (i > 0) { Console.WriteLine("Up: " + array[i-1,j]); }
                        if (i < lines - 1) { Console.WriteLine("Down: " + array[i+1, j]); }
                    }

                }
            }
        }
    }
}
