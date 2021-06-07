using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberSum = 0;
            int curentNumber = number;
            while (curentNumber != 0)
            {
                int digit = curentNumber % 10;
                int factorialNum = 1;
                for (int k = digit; k > 0; k--)
                {
                    factorialNum *= k;
                }
                numberSum += factorialNum;
                curentNumber = curentNumber / 10;
            }
            if (numberSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
