using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            string result = CheckMultiplicationSign(num1, num2, num3);
            Console.WriteLine(result);
        }

        static string CheckMultiplicationSign(int numA, int numB, int numC)
        {
            if (numA == 0 || numB == 0 || numC == 0)
            {
                return "zero";
            }
            if ((numA < 0 && numB < 0 && numC < 0) || (numA < 0 && numB > 0 && numC > 0) || (numA > 0 && numB < 0 && numC > 0) || (numA > 0 && numB > 0 && numC < 0))
            {
                return "negative";
            }
            return "positive";
        }
    }
}
