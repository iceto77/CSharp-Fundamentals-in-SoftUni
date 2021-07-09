using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTaxes = 0.0;
            string inputCommand = Console.ReadLine();
            while (inputCommand != "special" && inputCommand != "regular")
            {
                double curentPrice = double.Parse(inputCommand);
                if (curentPrice <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWithoutTaxes += curentPrice;
                }
                inputCommand = Console.ReadLine();
            }
            double totalPrice = totalPriceWithoutTaxes * 1.2;
            if (inputCommand == "special")
            {
                totalPrice *= 0.9;
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {totalPriceWithoutTaxes * 0.2:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
