using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int productionRate = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoryProduction = int.Parse(Console.ReadLine());
            double producedQuantity = 0;
            for (int i = 1; i <= 30; i++)
            {
                double dayQuantity = productionRate * countOfWorkers;
                if (i % 3 == 0)
                {
                   dayQuantity = Math.Floor(dayQuantity * 0.75);
                }
                producedQuantity += dayQuantity;
            }
            Console.WriteLine($"You have produced {producedQuantity} biscuits for the past month.");
            double difference = producedQuantity - competingFactoryProduction;
            if (difference > 0)
            {
                Console.WriteLine($"You produce {100 * difference / competingFactoryProduction:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {100 * Math.Abs(difference) / competingFactoryProduction:f2} percent less biscuits.");
            }
        }
    }
}
