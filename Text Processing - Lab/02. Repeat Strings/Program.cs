using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] curentText = Console.ReadLine().Split().ToArray();
            string newText = string.Empty;
            for (int i = 0; i < curentText.Length; i++)
            {
                for (int j = 0; j < curentText[i].Length; j++)
                {
                    newText += curentText[i];
                }
            }
            Console.WriteLine(newText);
        }
    }
}
