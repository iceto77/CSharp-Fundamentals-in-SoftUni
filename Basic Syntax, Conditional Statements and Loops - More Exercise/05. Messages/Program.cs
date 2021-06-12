using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] arr2 = { 'a', 'b', 'c'}; 
            //char[] arr3 = { 'd', 'e', 'f'}; 
            //char[] arr4 = { 'g', 'h', 'i'}; 
            //char[] arr5 = { 'j', 'k', 'l'}; 
            //char[] arr6 = { 'm', 'n', 'o'};
            //char[] arr7 = { 'p', 'q', 'r', 's'}; 
            //char[] arr8 = { 't', 'u', 'v'}; 
            //char[] arr9 = { 'w', 'x', 'y', 'z'};
            int n = int.Parse(Console.ReadLine());
            string exitText = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string inputText = Console.ReadLine();
                int numberOfDigits = inputText.Length;
                int nextComand = int.Parse(inputText) % 10;

                switch (nextComand)
                {
                    case 2:
                        exitText += (char)('a' + numberOfDigits - 1);
                        break;
                    case 3:
                        exitText += (char)('d' + numberOfDigits - 1);
                        break;
                    case 4:
                        exitText += (char)('g' + numberOfDigits - 1);
                        break;
                    case 5:
                        exitText += (char)('j' + numberOfDigits - 1);
                        break;
                    case 6:
                        exitText += (char)('m' + numberOfDigits - 1);
                        break;
                    case 7:
                        exitText += (char)('p' + numberOfDigits - 1);
                        break;
                    case 8:
                        exitText += (char)('t' + numberOfDigits - 1);
                        break;
                    case 9:
                        exitText += (char)('w' + numberOfDigits - 1);
                        break;
                    case 0:
                        exitText += " ";
                        break;
                }
            }
            Console.WriteLine(exitText);
        }
    }
}
