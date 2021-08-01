using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>[0-9]+[.]*[0-9]*)[!](?<qnt>[0-9]+)";
            double totalMoney = 0;
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                MatchCollection result = Regex.Matches(input, pattern);
                foreach (Match item in result)
                {
                    Console.WriteLine(item.Groups["name"].Value);
                    double price = double.Parse(item.Groups["price"].Value);
                    double quantity = double.Parse(item.Groups["qnt"].Value);
                    totalMoney += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
