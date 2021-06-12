using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Console.WriteLine(CountOfVowels(inputText));
            //count of the vowels
        }

        static int CountOfVowels(string inputText)
        {
            int count = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                switch (inputText[i])
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                        count++;
                        break;
                }

            }
            return count;
        }
    }
}
