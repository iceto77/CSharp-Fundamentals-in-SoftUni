using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class City
    {
        public City(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> targetedCities = new Dictionary<string, City>();
            while (input != "Sail")
            {
                string[] target = input.Split("||").ToArray();
                if (!targetedCities.ContainsKey(target[0]))
                {
                    targetedCities.Add(target[0], new City(0, 0));
                }
                targetedCities[target[0]].Population += int.Parse(target[1]);
                targetedCities[target[0]].Gold += int.Parse(target[2]);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split("=>").ToArray();
                switch (command[0])
                {
                    case "Plunder":
                        int curentGold = int.Parse(command[3]);
                        int curentPeople = int.Parse(command[2]);
                        targetedCities[command[1]].Population -= curentPeople;
                        targetedCities[command[1]].Gold -= curentGold;
                        Console.WriteLine($"{command[1]} plundered! {curentGold} gold stolen, {curentPeople} citizens killed.");
                        if (targetedCities[command[1]].Population <= 0 || targetedCities[command[1]].Gold <= 0)
                        {
                            Console.WriteLine($"{command[1]} has been wiped off the map!");
                            targetedCities.Remove(command[1]);
                        }
                        break;
                    case "Prosper":
                        int goldGrowth = int.Parse(command[2]);
                        if (goldGrowth >= 0)
                        {
                            targetedCities[command[1]].Gold += goldGrowth;
                            Console.WriteLine($"{goldGrowth} gold added to the city treasury. {command[1]} now has {targetedCities[command[1]].Gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            if (targetedCities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {targetedCities.Count} wealthy settlements to go to:");
                foreach (var item in targetedCities.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
