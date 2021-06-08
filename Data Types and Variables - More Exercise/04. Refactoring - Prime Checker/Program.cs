using System;

namespace _04._Refactoring___Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            for (int i = 2; i <= targetNum; i++)
            {
                bool isSimpleNum = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimpleNum = false;
                        break;
                    }
                }
                string boolText = "false";
                if (isSimpleNum)
                {
                    boolText = "true";
                }
                Console.WriteLine($"{i} -> {boolText}");
            }
        }
    }
}
