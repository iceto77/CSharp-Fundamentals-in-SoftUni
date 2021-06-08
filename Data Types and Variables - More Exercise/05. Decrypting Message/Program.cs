using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string exitText = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char inputChar = char.Parse(Console.ReadLine());
                char decipheredChar = (char)((int)inputChar + key);
                exitText += decipheredChar.ToString();
            }
            Console.WriteLine(exitText);
        }
    }
}
