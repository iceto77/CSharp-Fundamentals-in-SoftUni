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
                string input = Console.ReadLine();
                int j = 0;
                string firstNum = string.Empty;
                string secondNum = string.Empty;
                while ((int)input[j] != 32)
                {
                    firstNum += input[j];
                    j++;
                }
                j++;
                for (int k = j; k < input.Length; k++)
                {
                    secondNum += input[k];
                }
                BigInteger num1 = BigInteger.Parse(firstNum);
                BigInteger num2 = BigInteger.Parse(secondNum);
                BigInteger sum = 0;
                if (num1 > num2)
                {
                    for (int l = 0; l < firstNum.Length; l++)
                    {
                        sum += BigInteger.Parse(firstNum[l].ToString());
                    }
                }
                else
                {
                    for (int l = 0; l < secondNum.Length; l++)
                    {
                        sum += BigInteger.Parse(secondNum[l].ToString());
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
