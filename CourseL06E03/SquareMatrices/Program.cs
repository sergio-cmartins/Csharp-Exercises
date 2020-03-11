using System;

namespace SquareMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please infor the size of the square matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int line = 0; line < n; line++)
            {
                Console.Write("Please enter the {0} elements for the line #{1}:",n,line + 1);
                string[] inpStr = Console.ReadLine().Split(' ');
                for (int column = 0; column < n; column++)
                {
                    matrix[line, column] = int.Parse(inpStr[column]);
                }
            }

            //Find All negative Numbers:
            int neg = 0;
            foreach (int item in matrix)
            {
                if (item < 0)
                {
                    neg++;
                }
            }

            //Print the matrix diagonal (where line equals column) and print the total amount of negative numbers
            Console.WriteLine("\nMain Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine("\nAmount of Negative Numbers: " + neg);

        }
    }
}
