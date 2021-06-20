using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] tempArr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] curentArr = new int[i];
                for (int j = 0; j < i; j++)
                {
                    int numN = 0;
                    int numN_1 = 0;
                    if (i == 1)
                    {
                        numN = 1;
                        numN_1 = 0;
                    }
                    else if (j == 0)
                    {
                        numN = tempArr[j];
                        numN_1 = 0;
                    }
                    else
                    {
                        numN = tempArr[j];
                        numN_1 = tempArr[j - 1];
                    }
                    curentArr[j] = numN_1 + numN;
                }
                Console.WriteLine(string.Join(" ", curentArr));
                for (int j = 0; j < curentArr.Length; j++)
                {
                tempArr[j] = curentArr[j];
                }
            }
        }
    }
}
