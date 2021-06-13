using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            BigInteger firstNumFact = FactorialOfNumbers(firstNum);
            BigInteger secondNumFact = FactorialOfNumbers(secondNum);
            double result = DivideNumbers((double)firstNumFact, (double)secondNumFact);
            Console.WriteLine($"{result:f2}");
        }

        static BigInteger FactorialOfNumbers(int num)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            return sum;
        }

        static double DivideNumbers(double numA, double numB)
        {
            return numA / numB;
        }
    }
}
