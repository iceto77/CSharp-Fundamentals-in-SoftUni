using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());
            SmallestThreeNumbers(numA, numB, numC);
        }

        private static void SmallestThreeNumbers(int numA, int numB, int numC)
        {
            int numSmallest = numA;
            if (numB < numSmallest)
            {
                numSmallest = numB;
            }
            if (numC < numSmallest)
            {
                numSmallest = numC;
            }
            Console.WriteLine(numSmallest);
        }
    }
}
