using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double gatheredPlunders = 0;
            for (int i = 1; i <= days; i++)
            {
                gatheredPlunders += dailyPlunder;
                if (i % 3 == 0)
                {
                    gatheredPlunders += dailyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {
                    gatheredPlunders *= 0.7;
                }
            }
            if (gatheredPlunders >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gatheredPlunders:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(gatheredPlunders / expectedPlunder) * 100:f2}% of the plunder.");
            }
        }
    }
}
