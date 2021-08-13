using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordPattern = @"([:*])\1([A-Z][a-z]{2,})\1{2}";
            string digitPattern = @"([0-9])";
            string input = Console.ReadLine();
            MatchCollection findCoolThreshold = Regex.Matches(input, digitPattern);
            BigInteger coolThreshold = 1;

            foreach (Match item in findCoolThreshold)
            {
                coolThreshold *= int.Parse(item.Value);
            }
            MatchCollection findEmoji = Regex.Matches(input, wordPattern);
            int findedEmoji = findEmoji.Count;
            Dictionary<string, BigInteger> CoolEmoji = new Dictionary<string, BigInteger>();
            foreach (Match emoji in findEmoji)
            {
                string curentEmoji = emoji.Groups[2].Value;
                int curentCoolness = 0;
                for (int i = 0; i < curentEmoji.Length; i++)
                {
                    curentCoolness += curentEmoji[i];
                }
                if (curentCoolness > coolThreshold)
                {
                    CoolEmoji.Add(emoji.Value, curentCoolness);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{findedEmoji} emojis found in the text. The cool ones are:");
            if (CoolEmoji.Count > 0)
            {
                foreach (var item in CoolEmoji)
                {
                    Console.WriteLine($"{item.Key} ");
                }
            }
        }
    }
}
