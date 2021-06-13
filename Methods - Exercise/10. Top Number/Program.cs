using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                bool isDivisibleBy8 = DivisibleDigitsByEight(i);
                bool isContainsOddDigit = ContainsOddDigit(i);
                if (isDivisibleBy8 && isContainsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool DivisibleDigitsByEight(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }


        static bool ContainsOddDigit(int num)
        {
            int curentNum = 0;
            while (num != 0)
            {
                curentNum = num % 10;
                if (curentNum % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
