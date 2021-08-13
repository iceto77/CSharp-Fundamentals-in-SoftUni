using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string validationPattern = @"^([@]{1})([#]+)([A-Z][A-Za-z0-9]{4,}[A-Z])\1([#]+)$";
                string infoPattern = @"([0-9]+)";
                if (IsValidBarcode(input, validationPattern))
                {
                    string productGroup = string.Empty;
                    MatchCollection product = Regex.Matches(input, infoPattern);
                    if (product.Count > 0)
                    {
                        foreach (Match item in product)
                        {
                            productGroup += item.Value;
                        }
                    }
                    else
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }

        private static bool IsValidBarcode(string barcode, string pattern)
        {
            Regex validation = new Regex(pattern);
            return validation.IsMatch(barcode);
        }
    }
}
