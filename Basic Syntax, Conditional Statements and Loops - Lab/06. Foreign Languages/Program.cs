using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string usingLanguages = string.Empty;
            switch (countryName)
            {
                case "USA":
                case "England":
                    usingLanguages = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    usingLanguages = "Spanish";
                    break;
                default:
                    usingLanguages = "unknown";
                    break;
            }
            Console.WriteLine(usingLanguages);
        }
    }
}
