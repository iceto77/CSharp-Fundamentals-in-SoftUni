using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split()
                            .Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] + inputNumbers[j] == magicSum)
                    {
                        Console.WriteLine($"{inputNumbers[i]} {inputNumbers[j]}");
                    }

                }
            }
        }
    }
}
