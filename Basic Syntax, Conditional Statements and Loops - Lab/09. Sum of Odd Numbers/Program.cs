using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int countNum = 0;
            int sum = 0;
            while (countNum != n)
            {             
                if (count % 2 != 0)
                {
                    Console.WriteLine(count);
                    countNum++;
                    sum += count;
                }
                count++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
