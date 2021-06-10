using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        static int GetMultipleOfEvenAndOdds(int fullNum)
        {
            int result = 0;
            int number = Math.Abs(fullNum);
            result = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return result;
        }
        static int GetSumOfOddDigits(int inputNum)
        {
            int sum = 0;
            while (inputNum != 0)
            {
                int curentNum = inputNum % 10;
                if (curentNum % 2 != 0)
                {
                    sum += curentNum;
                }
                inputNum /= 10;
            }
            return sum;
        }

        static int GetSumOfEvenDigits(int inputNum)
        {
            int sum = 0;
            while (inputNum != 0)
            {
                int curentNum = inputNum % 10;
                if (curentNum % 2 == 0)
                {
                    sum += curentNum;
                }
                inputNum /= 10;
            }
            return sum;
        }
    }
}
