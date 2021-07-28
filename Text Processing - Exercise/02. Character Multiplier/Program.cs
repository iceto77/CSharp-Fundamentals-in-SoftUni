using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int limit = input[0].Length;
            int limitSmall = input[1].Length - 1;
            string a = input[0];
            string b = input[1];
            if (input[1].Length > input[0].Length)
            {
                limit = input[1].Length;
                limitSmall = input[0].Length - 1;
                a = input[1];
                b = input[0];
            }
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i > limitSmall)
                {
                    sum += a[i];
                }
                else
                {
                    sum += a[i] * b[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
