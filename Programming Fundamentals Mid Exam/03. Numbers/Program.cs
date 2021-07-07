using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            List<int> topFive = new List<int>();
            double averageValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                averageValue += numbers[i];
            }
            averageValue /= (double)numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > averageValue)
                {
                    topFive.Add(numbers[i]);
                }
            }
            if (topFive.Count > 0)
            {
                topFive.Sort();
                topFive.Reverse();
                for (int i = topFive.Count - 1; i >= 5; i--)
                {
                    topFive.RemoveAt(i);
                }
                Console.WriteLine(string.Join(" ", topFive));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
