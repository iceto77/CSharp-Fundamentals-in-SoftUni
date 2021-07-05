using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string inputComand = Console.ReadLine();
            int winCount = 0;
            bool win = true;
            while (inputComand != "End of battle")
            {
                int distance = int.Parse(inputComand);
                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCount} won battles and {energy} energy");
                    win = false;
                    inputComand = "End of battle";
                }
                else
                {
                    energy -= distance;
                    winCount++;
                    if (winCount % 3 == 0)
                    {
                        energy += winCount;
                    }
                    inputComand = Console.ReadLine();
                }
            }
            if (win)
            {
            Console.WriteLine($"Won battles: {winCount}. Energy left: {energy}");
            }
        }
    }
}
