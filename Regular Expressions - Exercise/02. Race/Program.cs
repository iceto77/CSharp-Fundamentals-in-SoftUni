using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";
            string[] racersName = input.Split(", ");
            Dictionary<string, int> racers = new Dictionary<string, int>();
            for (int i = 0; i < racersName.Length; i++)
            {
                if (!racers.ContainsKey(racersName[i]))
                {
                    racers.Add(racersName[i], 0);
                }
            }
            input = Console.ReadLine();
            while (input != "end of race")
            {
                MatchCollection curentName = Regex.Matches(input, namePattern);
                string name = string.Empty;
                foreach (var stepName in curentName)
                {
                    name += stepName;
                }
                if (racers.ContainsKey(name))
                {
                    MatchCollection curentDistance = Regex.Matches(input, distancePattern);
                    int distance = 0;
                    foreach (var stepDistance in curentDistance)
                    {
                        distance += int.Parse(stepDistance.ToString());
                    }
                    racers[name] += distance;
                }
                input = Console.ReadLine();
            }
            int posCount = 1;
            foreach (var item in racers.OrderByDescending(x => x.Value))
            {
                string position = string.Empty;
                switch (posCount)
                {
                    case 1:
                        position = "1st";
                        break;
                    case 2:
                        position = "2nd";
                        break;
                    case 3:
                        position = "3rd";
                        break;
                }
                Console.WriteLine($"{position} place: {item.Key}");
                posCount++;
                if (posCount > 3)
                {
                    break;
                }
            }
        }
    }
}
