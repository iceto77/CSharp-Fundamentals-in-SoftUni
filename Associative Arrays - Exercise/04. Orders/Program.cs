using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "buy")
            {
                string[] infoProduct = inputCommand.Split().ToArray();
                double[] priceQuantity = { double.Parse(infoProduct[1]), double.Parse(infoProduct[2]) };
                if (!products.ContainsKey(infoProduct[0]))
                {
                    products.Add(infoProduct[0],priceQuantity);
                }
                else
                {
                    products[infoProduct[0]][1] += priceQuantity[1];
                    products[infoProduct[0]][0] = priceQuantity[0];
                }                
                inputCommand = Console.ReadLine();
            }
            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
