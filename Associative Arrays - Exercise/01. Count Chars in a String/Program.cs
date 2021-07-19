using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var charCount = new Dictionary<char, int>();
            string inputText = Console.ReadLine();
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == ' ')
                {
                    continue;
                }
                if (charCount.ContainsKey(inputText[i]))
                {
                    charCount[inputText[i]]++;
                }
                else
                {
                    charCount.Add(inputText[i], 1);     
                }
            }
            foreach (var (key, value) in charCount)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
