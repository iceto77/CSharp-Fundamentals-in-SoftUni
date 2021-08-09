using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#]{1})(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            MatchCollection mirrorMatches = Regex.Matches(input, pattern);
            List<string> mirrorWords = new List<string>();
            if (mirrorMatches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{mirrorMatches.Count} word pairs found!");
                foreach (Match item in mirrorMatches)
                {
                    if (IsMirrorWords(item.Groups["wordOne"].Value, item.Groups["wordTwo"].Value))
                    {
                        if (!mirrorWords.Contains(item.Groups["wordOne"].Value + " <=> " + item.Groups["wordTwo"].Value))
                        {
                            mirrorWords.Add(item.Groups["wordOne"].Value + " <=> " + item.Groups["wordTwo"].Value);
                        }
                    }
                }
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.Write(string.Join(", ", mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }

        private static bool IsMirrorWords(string textOne, string textTwo)
        {
            if (textOne.Length != textTwo.Length)
            {
                return false;
            }
            else
            {
                int end = textOne.Length - 1;
                for (int i = 0; i < textOne.Length; i++)
                {
                    if (textOne[i] != textTwo[end - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
