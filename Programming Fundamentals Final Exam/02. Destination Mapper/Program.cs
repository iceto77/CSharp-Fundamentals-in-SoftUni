using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([=\/]{1})(?<name>[A-Z][A-Za-z]{2,})\1";
            MatchCollection validLocations = Regex.Matches(input, pattern);
            int travelPoints = 0;
            List<string> destinations = new List<string>();
            foreach (Match item in validLocations)
            {
                if (!destinations.Contains(item.Groups["name"].Value))
                {
                    destinations.Add(item.Groups["name"].Value);
                }
            }
            foreach (var item in destinations)
            {
                travelPoints += item.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
