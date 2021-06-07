using System;
using System.Linq;

namespace _802.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Console.ReadLine()
                .Select(x => int.Parse(x.ToString()))
                .Sum();
            Console.WriteLine(sum);

            //ВТОРИ ВАРИАНТ
            //int inputNumber = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (inputNumber > 0)
            //{
            //    sum += inputNumber % 10;
            //    inputNumber /= 10;
            //}
            //Console.WriteLine(sum);

            // ПЪРВИ ВАРИАНТ
            //    string inputNumber = Console.ReadLine();
            //    int sum = 0;
            //    for (int i = 0; i < inputNumber.Length; i++)
            //    {
            //        sum += (int)Char.GetNumericValue(inputNumber[i]);
            //    }
            //    Console.WriteLine(sum);
        }
    }
}
