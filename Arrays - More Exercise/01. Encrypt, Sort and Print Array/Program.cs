using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                string inputString = Console.ReadLine();
                int[] input = new int[inputString.Length];
                for (int j = 0; j < inputString.Length; j++)
                {
                    input[j] = inputString[j];
                }
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    switch (input[j])
                    {
                        case 65:
                        case 69:
                        case 73:
                        case 79:
                        case 85:
                        case 97:
                        case 101:
                        case 105:
                        case 111:
                        case 117:
                            sum += input[j] * inputString.Length;
                            break;
                        default:
                            sum += input[j] / inputString.Length;
                            break;
                    }
                }
                result[i] = sum;
            }
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    int curentNum = result[i];
                    if (result[j] < result[i])
                    {
                        result[i] = result[j];
                        result[j] = curentNum;
                    }
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
