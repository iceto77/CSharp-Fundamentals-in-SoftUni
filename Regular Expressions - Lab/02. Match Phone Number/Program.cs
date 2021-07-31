using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][3][5][9]([\s-])[2]\1[0-9]{3}\1[0-9]{4}\b";
            string input = Console.ReadLine();
            MatchCollection result = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
