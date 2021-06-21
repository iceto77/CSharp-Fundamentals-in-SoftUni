using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int count = 0;
            if (firstNumbers.Count >= secondNumbers.Count)
            {
                count = firstNumbers.Count;
            }
            else
            {
                count = secondNumbers.Count;
            }
            for (int i = 0; i < count; i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
