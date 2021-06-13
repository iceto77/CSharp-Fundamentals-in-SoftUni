using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int sum = SumTwoNumbers(firstNum, secondNum);
            Console.WriteLine(SubtractTwoNumber(sum, thirdNum));
        }

        static int SubtractTwoNumber(int NumA, int NumB)
        {
            return NumA - NumB;
        }

        static int SumTwoNumbers(int NumA, int NumB)
        {
            return NumA + NumB;
        }
    }
}
