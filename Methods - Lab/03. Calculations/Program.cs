using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            Calculations(operation, numOne, numTwo);
        }

        static void Calculations(string operationType, int firstNum, int secondNum)
        {
            int sum = 0;
            switch (operationType)
            {
                case "add":
                    sum = firstNum + secondNum;
                    break;
                case "multiply":
                    sum = firstNum * secondNum;
                    break;
                case "subtract":
                    sum = firstNum - secondNum;
                    break;
                case "divide":
                    sum = firstNum / secondNum;
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}
