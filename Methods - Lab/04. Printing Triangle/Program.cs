using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintingTriangle(num);
        }
        static void PrintingTriangle(int numberOfDigits)
        {
            for (int row = 1; row <= numberOfDigits; row++)
            {
                PrintColumn(row);
            }
            for (int row = numberOfDigits - 1; row >= 1; row--)
            {
                PrintColumn(row);
            }
        }

        private static void PrintColumn(int row)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write($"{column} ");
            }
            Console.WriteLine();
        }
    }
}
