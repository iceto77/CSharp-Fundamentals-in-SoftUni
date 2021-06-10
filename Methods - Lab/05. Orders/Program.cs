using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            CalculateAmount(product, number);
        }

        static void CalculateAmount(string item, int quantity)
        {
            double amount = 0.0;
            switch (item)
            {
                case "coffee" :
                    amount = quantity * 1.50;
                    break;
                case "water":
                    amount = quantity * 1.00;
                    break;
                case "coke":
                    amount = quantity * 1.40;
                    break;
                case "snacks":
                    amount = quantity * 2.00;
                    break;
            }
            Console.WriteLine($"{amount:f2}");
        }
    }
}
