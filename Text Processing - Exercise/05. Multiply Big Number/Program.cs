using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int curentSum = 0;
            StringBuilder result = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                string a = input[i].ToString();                
                curentSum += int.Parse(a) * multiplier;
                if (curentSum > 9)
                {
                    int y = curentSum % 10;
                    result.Insert(0, y);
                    curentSum = curentSum / 10;
                }
                else
                {
                    result.Insert(0, curentSum);
                    curentSum = 0;
                }
            }
            if (curentSum != 0)
            {
                result.Insert(0, curentSum);
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == '0' && i != result.Length - 1)
                {
                    result.Remove(i, 1);
                    i--;
                }
                else if (result[i] != '0')
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
