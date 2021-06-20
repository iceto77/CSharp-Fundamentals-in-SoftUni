using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] firstLine = new int[inputArr.Length / 2];
            int[] secondLine = new int[firstLine.Length];
            int k = inputArr.Length / 4;
            for (int i = 0; i < k; i++)
            {
                firstLine[k - i - 1] = inputArr[i];
            }
            for (int i = k - 1; i >= 0; i--)
            {
                firstLine[firstLine.Length - 1 - i] = inputArr[inputArr.Length - k + i];
            }
            for (int i = 0; i < secondLine.Length; i++)
            {
                secondLine[i] = inputArr[k + i];
            }
            int[] result = new int[firstLine.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstLine[i] + secondLine[i];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
