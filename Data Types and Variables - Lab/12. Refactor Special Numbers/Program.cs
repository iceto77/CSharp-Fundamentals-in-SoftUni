using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpecialNumber = false;
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int curentNum = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", curentNum, isSpecialNumber);
                i = curentNum;
            }
        }
    }
}
