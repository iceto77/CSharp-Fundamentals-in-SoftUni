using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            bool isTopInteger = true;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = i+1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] <= inputNumbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{inputNumbers[i]} ");
                }
                else
                {
                    isTopInteger = true;
                }
            }
        }
    }
}
