using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split()
                .Select(double.Parse).ToList();
            bool isAdjacentEqualNumbers = true;
            while (isAdjacentEqualNumbers)
            {
                isAdjacentEqualNumbers = false;
                List<int> delList = new List<int>();
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i - 1] == numbers[i])
                    {
                        isAdjacentEqualNumbers = true;
                        numbers[i - 1] += numbers[i];
                        delList.Add(i);
                        break; // ????
                    }
                }
                for (int i = 0; i < delList.Count; i++)
                {
                    numbers.RemoveAt(delList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
