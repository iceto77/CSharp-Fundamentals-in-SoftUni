using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%.*<(?<item>\w+)>.*\|(?<qnt>\d+)\|.*?(?<price>[\d.]+)\$$";
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(input))
                {
                    Match goods = regex.Match(input);
                    double totalPrice = double.Parse(goods.Groups["qnt"].Value) * double.Parse(goods.Groups["price"].Value);
                    Console.WriteLine($"{goods.Groups["customer"].Value}: {goods.Groups["item"].Value} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
