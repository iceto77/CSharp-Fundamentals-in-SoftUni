using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            int randomPosition = rnd.Next(0, inputText.Count - 1);
            for (int i = 0; i < inputText.Count; i++)
            {
                string tempString = inputText[i];
                inputText[i] = inputText[randomPosition];
                inputText[randomPosition] = tempString;
                randomPosition = rnd.Next(0, inputText.Count - 1);
            }
            Console.WriteLine(string.Join("\n", inputText));
        }
    }
}
