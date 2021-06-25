using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            string inputText = Console.ReadLine();
            List<char> charText = new List<char>();
            for (int i = 0; i < inputText.Length; i++)
            {
                charText.Add(inputText[i]);
            }
            string resultText = string.Empty;
            int sumOfDigit = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sumOfDigit = CalcSumOfDigit(numbers[i]);
                if (sumOfDigit > charText.Count)
                {
                    sumOfDigit = sumOfDigit % charText.Count;
                }
                resultText += charText[sumOfDigit];
                charText.RemoveAt(sumOfDigit);
            }
            Console.WriteLine(resultText);
        }

        private static int CalcSumOfDigit(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int curentNum = num % 10;
                sum += curentNum;
                num /= 10;
            }
            return sum;
        }
    }
}
