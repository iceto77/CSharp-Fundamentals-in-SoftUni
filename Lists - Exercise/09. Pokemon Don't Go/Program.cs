using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            int sum = 0;
            while (numbers.Count > 0)
            {
                int targetIdex = int.Parse(Console.ReadLine());
                int targetNum = 0;
                if (targetIdex < 0)
                {
                    targetNum = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
                else if (targetIdex >= numbers.Count)
                {
                    targetNum = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }
                else
                {
                    targetNum = numbers[targetIdex];
                    numbers.RemoveAt(targetIdex);
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > targetNum)
                    {
                        numbers[i] -= targetNum;
                    }
                    else
                    {
                        numbers[i] += targetNum;
                    }
                }
                sum += targetNum;
            }
            Console.WriteLine(sum);
        }
    }
}
