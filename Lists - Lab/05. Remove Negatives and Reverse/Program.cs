using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                 .Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                }
            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result.Add(numbers[i]);
            }
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
