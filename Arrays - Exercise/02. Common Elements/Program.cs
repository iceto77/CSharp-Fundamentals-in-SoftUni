using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstText = Console.ReadLine().Split();
            string[] secondText = Console.ReadLine().Split();

            // втори начин

            string[] aggregateText = secondText.Intersect(firstText).ToArray();
            Console.WriteLine(string.Join(" ", aggregateText));



            // първи начин

            //string[] aggregateText = new string[secondText.Length];
            //int k = 0;
            //for (int i = 0; i < secondText.Length; i++)
            //{
            //    for (int j = 0; j < firstText.Length; j++)
            //    {
            //        if (firstText[j] == secondText[i])
            //        {
            //            aggregateText[k] = firstText[j];
            //            k++;
            //        }
            //    }
            //}
            //for (int i = 0; i < aggregateText.Length; i++)
            //{
            //    Console.Write($"{aggregateText[i]} ");
            //}
        }
    }
}
