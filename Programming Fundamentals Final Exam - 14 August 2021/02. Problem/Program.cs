using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"^([$%]{1})([A-Z][a-z]{2,})\1([:][\s])([\[][0-9]+[\]][|][\[][0-9]+[\]][|][\[][0-9]+[\]][|])$";
                string criyptedPattern = @"([\[])([0-9]+)(\])";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    string tag = match.Groups[2].Value;
                    string groupsOfNumbers = match.Groups[4].Value;
                    MatchCollection cryptedMessage = Regex.Matches(groupsOfNumbers, criyptedPattern);
                    string decryptedMessage = string.Empty;
                    foreach (Match item in cryptedMessage)
                    {
                        decryptedMessage += (char)(int.Parse(item.Groups[2].Value));
                    }
                    Console.WriteLine($"{tag}: {decryptedMessage}");
        }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }
        }
    }
}
