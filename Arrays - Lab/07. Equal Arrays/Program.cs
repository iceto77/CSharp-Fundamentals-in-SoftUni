using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();
            bool isIdentical = true;
            int indexNum = 0;
            int sum = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    isIdentical = false;
                    indexNum = i;
                    break;
                }
                sum += arrayOne[i];
            }
            if (isIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexNum} index");
            }
        }
    }
}
