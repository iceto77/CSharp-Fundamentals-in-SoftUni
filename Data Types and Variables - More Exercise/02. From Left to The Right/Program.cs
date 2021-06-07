using System;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputText = Console.ReadLine();
                string[] text = inputText.Split();
                string leftNum = text[0];
                BigInteger numL = BigInteger.Parse(leftNum);
                string rightNum = text[1];
                BigInteger numR = BigInteger.Parse(rightNum);
                int sum = 0;
                if (numL > numR)
                {
                    for (int j = 0; j < leftNum.Length; j++)
                    {
                        sum += int.Parse(leftNum[j].ToString());
                    }
                }
                else
                {
                    for (int j = 0; j < rightNum.Length; j++)
                    {
                        sum += int.Parse(rightNum[j].ToString());
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
