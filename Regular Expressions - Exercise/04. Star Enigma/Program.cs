using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int attackedPlanetsCount = 0;
            int destroyedPlanetsCount = 0;
            for (int i = 0; i < n; i++)
            {
                string input =Console.ReadLine();
                string decryptPattern = @"[arstARST]";
                string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<type>[AD]{1})![^@\-!:>]*->(?<count>[0-9]+)";
                MatchCollection decrypt = Regex.Matches(input, decryptPattern);
                int decryptRatio = decrypt.Count;
                string decryptText = string.Empty;
                for (int k = 0; k < input.Length; k++)
                {
                    int newChar = (int)input[k] - decryptRatio;
                    decryptText += (char)newChar;
                }
                Regex result = new Regex(pattern);
                if (result.IsMatch(decryptText))
                {
                    if (result.Match(decryptText).Groups["type"].Value == "A")
                    {
                        attackedPlanetsCount++;
                        attackedPlanets.Add(result.Match(decryptText).Groups["planet"].Value);
                    }
                    else
                    {
                        destroyedPlanetsCount++;
                        destroyedPlanets.Add(result.Match(decryptText).Groups["planet"].Value);
                    }
                }
            }
            
            Console.WriteLine($"Attacked planets: {attackedPlanetsCount}");
            foreach (var item in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanetsCount}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
