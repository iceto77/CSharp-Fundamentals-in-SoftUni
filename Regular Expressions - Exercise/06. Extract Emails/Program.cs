using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string mailPattern = @"(?<=\s)([A-Za-z0-9][A-Za-z0-9.\-_]+)@([a-zA-Z][-.A-Za-z]+)(\.[a-z]{2,})";
            string input = Console.ReadLine();
            MatchCollection validMails = Regex.Matches(input, mailPattern);
            foreach (Match item in validMails)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
