using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = GetFibonacci(num);
            Console.WriteLine(result);
        }

        static int GetFibonacci(int numN)
        {
            int[] FibonacciArr = new int[numN];
            for (int i = 0; i < FibonacciArr.Length; i++)
            {
                if (i == 0)
                {
                    FibonacciArr[i] = 1;
                }
                else if (i == 1)
                {
                    FibonacciArr[i] = 1;   
                }
                else if (i > 1)
                {
                    FibonacciArr[i] = FibonacciArr[i - 1] + FibonacciArr[i - 2]; 
                }
            }
            return FibonacciArr[numN - 1];
        }
    }
}
