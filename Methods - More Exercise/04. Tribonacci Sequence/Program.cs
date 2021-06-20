using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int[] numbers = new int[inputNum];
            numbers[0] = 1;
            for (int i = 1; i <= inputNum; i++)
            {
                numbers = CurentTribonacciNum(i, numbers);
            }
            Console.Write(string.Join(" ", numbers));
        }

        static int[] CurentTribonacciNum(int curentNum, int[] numArr)
        {
            int x_1 = curentNum - 2;
            int x_2 = curentNum - 3;
            int x_3 = curentNum - 4;
            if (x_1 < 0)
            {
                x_1 = 1;
            }
            else
            {
                x_1 = numArr[curentNum - 2];
            }
            if (x_2 < 0)
            {
                x_2 = 0;
            }
            else
            {
                x_2 = numArr[curentNum - 3];
            }
            if (x_3 < 0)
            {
                x_3 = 0;
            }
            else
            {
                x_3 = numArr[curentNum - 4];
            }
            int sum = x_3 + x_2 + x_1;
            numArr[curentNum - 1] = sum;
            return numArr;
        }
    }
}
