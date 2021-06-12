using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string exitText = string.Empty;
            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                exitText += inputText[i];
            }
            Console.WriteLine(exitText);
        }
    }
}
