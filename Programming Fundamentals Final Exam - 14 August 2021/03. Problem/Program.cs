using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int unlikedMealsCount = 0;
            Dictionary<string, List<string>> guestsLikedMeal = new Dictionary<string, List<string>>();
            while (input != "Stop")
            {
                string[] command = input.Split("-").ToArray();
                switch (command[0])
                {
                    case "Like":
                        if (!guestsLikedMeal.ContainsKey(command[1]))
                        {
                            guestsLikedMeal.Add(command[1], new List<string>());
                        }
                        if (!guestsLikedMeal[command[1]].Contains(command[2]))
                        {
                            guestsLikedMeal[command[1]].Add(command[2]);
                        }
                        break;
                    case "Unlike":
                        if (guestsLikedMeal.ContainsKey(command[1]))
                        {
                            if (guestsLikedMeal[command[1]].Contains(command[2]))
                            {
                                guestsLikedMeal[command[1]].Remove(command[2]);
                                unlikedMealsCount++;
                                Console.WriteLine($"{command[1]} doesn't like the {command[2]}.");
                            }
                            else
                            {
                                Console.WriteLine($"{command[1]} doesn't have the {command[2]} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is not at the party.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in guestsLikedMeal.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: "+ string.Join(", ", item.Value));
            }
            Console.WriteLine($"Unliked meals: {unlikedMealsCount}");

            //o    "Like-{guest}-{meal}"
            //o   "Unlike-{guest}-{meal}"

        }
    }
}
