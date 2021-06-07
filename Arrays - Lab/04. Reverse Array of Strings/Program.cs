using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split();
            for (int i = 0; i < inputText.Length / 2; i++)
            {
                string tempText = inputText[i];
                inputText[i] = inputText[inputText.Length - 1 - i];
                inputText[inputText.Length - 1 - i] = tempText;
            }
            foreach (var text in inputText)
            {
                Console.Write(text + " ");
            }
        }
    }
}
