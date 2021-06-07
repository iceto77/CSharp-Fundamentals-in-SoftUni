using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int equalIndex = 0;
            bool isExisting = false;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += inputNumbers[j];
                }
                for (int k = i + 1; k < inputNumbers.Length; k++)
                {
                    rightSum += inputNumbers[k];
                }
                if (leftSum == rightSum)
                {
                    equalIndex = i;
                    isExisting = true;
                }
            }
            if (isExisting)
            {
                Console.WriteLine(equalIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
