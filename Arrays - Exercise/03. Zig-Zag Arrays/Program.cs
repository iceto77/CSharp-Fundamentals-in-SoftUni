using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] inputText = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    firstArray[i] = int.Parse(inputText[0]);
                    secondArray[i] = int.Parse(inputText[1]);
                }
                else
                {
                    firstArray[i] = int.Parse(inputText[1]);
                    secondArray[i] = int.Parse(inputText[0]);
                }
            }
      
            // втори вариант

            Console.WriteLine(string.Join(" ",firstArray));
            Console.WriteLine(string.Join(" ",secondArray));

            //първи вариант

            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    Console.Write($"{firstArray[i]} ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < secondArray.Length; i++)
            //{
            //    Console.Write($"{secondArray[i]} ");
            //}
        }
    }
}
