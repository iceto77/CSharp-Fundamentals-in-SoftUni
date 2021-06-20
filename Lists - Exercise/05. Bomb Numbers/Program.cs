using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            int[] bombInstruction = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int targetIndex = -1;
            while (numbers.Contains(bombInstruction[0]))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bombInstruction[0])
                    {
                        targetIndex = i;
                        break;
                    }
                }
                int startIndex = targetIndex - bombInstruction[1];
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                int endIndex = targetIndex + bombInstruction[1];
                if (endIndex >= numbers.Count)
                {
                    endIndex = numbers.Count - 1;
                }
                if (startIndex < numbers.Count)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        numbers[i] = 0;
                    }
                }
            }
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
