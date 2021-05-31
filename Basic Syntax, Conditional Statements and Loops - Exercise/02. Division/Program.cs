using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            if (inputNum % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (inputNum % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (inputNum % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (inputNum % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (inputNum % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
