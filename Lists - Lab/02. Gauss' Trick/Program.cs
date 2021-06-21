using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int count = 0;
            if (numbers.Count % 2 == 0)
            {
                count = numbers.Count / 2;
            }
            else
            {
                count = numbers.Count / 2 + 1;
            }
            for (int i = 0; i < count; i++)
            {
                if (!(i == (numbers.Count - 1 - i)))
                {
                    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
                }
                else
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
