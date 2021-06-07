using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAmount = 0.0;
            while (input != "Start")
            {
                double insertSum = double.Parse(input);
                switch (insertSum)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        totalAmount += insertSum;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {insertSum}");
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                double paymentAmount = 0.0;
                switch (input)
                {
                    case "Nuts":
                        paymentAmount = 2.0;
                        break;
                    case "Water":
                        paymentAmount = 0.7;
                        break;
                    case "Crisps":
                        paymentAmount = 1.5;
                        break;
                    case "Soda":
                        paymentAmount = 0.8;
                        break;
                    case "Coke":
                        paymentAmount = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        input = Console.ReadLine();
                        continue;
                }
                if (paymentAmount > totalAmount)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {input.ToLower()}");
                    totalAmount -= paymentAmount;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalAmount:f2}");
        }
    }
}