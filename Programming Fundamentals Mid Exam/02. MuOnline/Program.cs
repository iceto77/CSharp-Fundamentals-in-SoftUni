using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] dungeonsRooms = Console.ReadLine().Split("|");
            for (int i = 0; i < dungeonsRooms.Length; i++)
            {
                string[] command = dungeonsRooms[i].Split();
                switch (command[0])
                {
                    case "potion":
                        int amount = int.Parse(command[1]);
                        if (health + amount > 100)
                        {
                            amount = Math.Abs(health - 100);
                            health = 100;
                        }
                        else
                        {
                            health += amount;
                        }
                        Console.WriteLine($"You healed for {amount} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += int.Parse(command[1]);
                        Console.WriteLine($"You found {command[1]} bitcoins.");
                        break;
                    default:
                        health -= int.Parse(command[1]);
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {command[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {command[0]}.");
                        }
                        break;
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
