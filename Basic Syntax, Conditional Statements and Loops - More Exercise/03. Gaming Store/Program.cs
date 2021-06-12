using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string nextCommand = Console.ReadLine();
            double totalSpent = 0;
            while (nextCommand != "Game Time")
            {
                double gamePrice = 0;
                bool isPurchase = true;
                switch (nextCommand)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        isPurchase = false;
                        break;
                }
                if (currentBalance < gamePrice)
                {
                    Console.WriteLine("Too Expensive");
                    isPurchase = false;
                }
                if (currentBalance >= gamePrice && isPurchase)
                {
                    Console.WriteLine($"Bought {nextCommand}");
                    currentBalance -= gamePrice;
                    totalSpent += gamePrice;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                nextCommand = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
