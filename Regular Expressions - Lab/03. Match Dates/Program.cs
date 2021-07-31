using System;
using System.Text.RegularExpressions;


namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>[0-9]{2})(?<sep>.)(?<month>[A-Z][a-z]{2})\k<sep>(?<year>[0-9]{4})";
            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
