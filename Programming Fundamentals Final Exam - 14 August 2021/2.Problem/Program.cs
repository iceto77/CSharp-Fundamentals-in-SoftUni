using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^>]+)[>](\d{3})[|]([a-z]{3})[|]([A-Z]{3})[|]([^><]{3})[<]\1$";
            string input = Console.ReadLine();
            int num = int.Parse(input);
            for (int i = 0; i < num; i++)
            {
                string newPass = string.Empty;
                input = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);
                    newPass = match.Groups[2].Value + match.Groups[3].Value + match.Groups[4].Value + match.Groups[5].Value;
                    Console.WriteLine($"Password: {newPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
