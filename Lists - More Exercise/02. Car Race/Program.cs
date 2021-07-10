using System;
using System.Linq;
using System.Numerics;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] carRace = Console.ReadLine().Split()
                .Select(BigInteger.Parse).ToArray();
            BigInteger midle = carRace.Length / 2;
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < midle; i++)
            {
                leftSum += (double)carRace[i];
                if (carRace[i] == 0)
                {
                    leftSum *= 0.8d;
                }
            }
            for (int i = carRace.Length - 1; i > midle; i--)
            {
                rightSum += (double)carRace[i];
                if (carRace[i] == 0)
                {
                    rightSum *= 0.8d;
                }
            }
            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else if (leftSum > rightSum)
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
