using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Problem
{
    class Program
    {
        class Animal
        {
            public Animal(int food, List<string> areas)
            {
                Food = food;
                Areas = areas;
            }

            public int Food { get; set; }
            public List<string> Areas { get; set; }

        }
        static void Main(string[] args)
        {
            Dictionary<string, Animal> dailyFeeding = new Dictionary<string, Animal>();
            string input = Console.ReadLine();
            while (input != "EndDay")
            {
                char[] separators = new char[] { ':', '-', ' ' };
                string[] command = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Add":
                        string animalName = command[1];
                        int neededFood = int.Parse(command[2]);
                        string curentArea = command[3];
                        if (!dailyFeeding.ContainsKey(animalName))
                        {
                            dailyFeeding.Add(animalName, new Animal(0, new List<string>()));
                        }
                        dailyFeeding[animalName].Food += neededFood;
                        if (!dailyFeeding[animalName].Areas.Contains(curentArea))
                        {
                            dailyFeeding[animalName].Areas.Add(curentArea);
                        }


                        break;
                    case "Feed":
                        animalName = command[1];
                        int rediceFood = int.Parse(command[2]);
                        if (dailyFeeding.ContainsKey(animalName))
                        {
                            dailyFeeding[animalName].Food -= rediceFood;
                            if (dailyFeeding[animalName].Food <= 0)
                            {
                                Console.WriteLine($"{animalName} was successfully fed");
                                dailyFeeding.Remove(animalName);
                            }
                        }


                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Animals: ");
            foreach (var item in dailyFeeding.OrderByDescending(x => x.Value.Food).ThenBy(x => x.Key))
            {
                Console.WriteLine($" {item.Key} -> {item.Value.Food}g");
            }
            Dictionary<string, int> areas = new Dictionary<string, int>();
            foreach (var item in dailyFeeding)
            {
                if (item.Value.Areas.Count > 0)
                {
                    foreach (var place in item.Value.Areas)
                    {
                        if (!areas.ContainsKey(place))
                        {
                            areas.Add(place, 0);
                        }
                        areas[place]++;
                    }

                }
            }
            Console.WriteLine("Areas with hungry animals:");
            foreach (var item in areas.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($" {item.Key}: {item.Value}");
            }
        }
    }
}
