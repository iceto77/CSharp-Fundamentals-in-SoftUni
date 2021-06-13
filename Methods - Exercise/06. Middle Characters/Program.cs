using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(inputText));            
        }

        static string MiddleCharacter(string inputText)
        {
            bool isEven = false;
            if (inputText.Length % 2 == 0)
            {
                isEven = true;
                int middle = inputText.Length / 2;
                return (inputText[middle - 1].ToString() + inputText[middle].ToString());
            }
            else
            {
                int middle = (inputText.Length / 2) + 1;
                return inputText[middle - 1].ToString();
            }
        }
    }
}
