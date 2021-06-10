using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char comand = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine($"{ReturnReesultOfOperation(comand, firstNum, secondNum)}"); ;
        }

        static double ReturnReesultOfOperation(char comand, double firstNum, double secondNum)
        {
            if (comand == '+')
            {
                return (firstNum + secondNum);
            }
            else if (comand == '-')
            {
                return (firstNum - secondNum);
            }
            else if (comand == '*')
            {
                return (firstNum * secondNum);
            }
            else if (comand == '/')
            {
                return (firstNum / secondNum);
            }
            else
            {
                return 0;
            }
        }
    }
}
