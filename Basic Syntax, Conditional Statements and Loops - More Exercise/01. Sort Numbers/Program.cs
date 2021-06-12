using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;
            if (numA > numB && numA > numC)
            {
                firstNum = numA;
                if (numB > numC)
                {
                    secondNum = numB;
                    thirdNum = numC;
                }
                else
                {
                    secondNum = numC;
                    thirdNum = numB;
                }

            }
            else if (numB > numA && numB > numC)
            {
                firstNum = numB;
                if (numA > numC)
                {
                    secondNum = numA;
                    thirdNum = numC;
                }
                else
                {
                    secondNum = numC;
                    thirdNum = numA;
                }
            }
            else if (numC > numA && numC > numB)
            {
                firstNum = numC;
                if (numA > numB)
                {
                    secondNum = numA;
                    thirdNum = numB;
                }
                else
                {
                    secondNum = numB;
                    thirdNum = numA;
                }
            }
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);
        }
    }
}
