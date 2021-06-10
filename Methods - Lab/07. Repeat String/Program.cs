using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CreateDuplicateText(inputText, n));
        }

        static string CreateDuplicateText(string input, int iterations)
        {
            string result = string.Empty;
            for (int i = 0; i < iterations; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
