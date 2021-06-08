using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            firstNum *= 1000000;
            secondNum *= 1000000;
            double difference = firstNum - secondNum;
            if (difference < 0)
            {
                difference *= -1;
            }
            bool isEqual = false;
            if (difference < 1)
            {
                isEqual = true;
            }
            Console.WriteLine(isEqual);
        }
    }
}
