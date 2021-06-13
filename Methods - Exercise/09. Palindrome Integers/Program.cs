using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            while (inputText != "END")
            {
                if (IsPalindrome(inputText))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                inputText = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string inputText)
        {
            string reverseText = ReverseString(inputText);
            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] != reverseText[i])
                {
                    return false;
                }
            }
            return true;
        }

        static string ReverseString(string inputText)
        {
            string newText = string.Empty;
            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                newText += inputText[i];
            }
            return newText;
        }
    }
}
