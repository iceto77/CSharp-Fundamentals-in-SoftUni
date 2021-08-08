using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Plant
    {
        public Plant(int rarity, List<int> rating)
        {
            Rarity = rarity;
            Rating = rating;
            //AverageRating = averageRating;
        }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }
        public double AverageRating { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int plantNum = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            string input = string.Empty;
            for (int i = 0; i < plantNum; i++)
            {
                input = Console.ReadLine();
                string[] curentPlant = input.Split("<->").ToArray();
                if (!plants.ContainsKey(curentPlant[0]))
                {
                    plants.Add(curentPlant[0], new Plant(int.Parse(curentPlant[1]), new List<int>()));
                }
                else
                {
                    plants[curentPlant[0]].Rarity = int.Parse(curentPlant[1]);
                }
            }
            input = Console.ReadLine();
            while (input != "Exhibition")
            {
                string[] command = input.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Rate":
                        if (plants.ContainsKey(command[1]))
                        {
                            plants[command[1]].Rating.Add(int.Parse(command[2]));
                            int sumRating = 0;
                            foreach (var item in plants[command[1]].Rating)
                            {
                                sumRating += item;
                            }
                            plants[command[1]].AverageRating = 1.0 * sumRating / plants[command[1]].Rating.Count;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Update":
                        if (plants.ContainsKey(command[1]))
                        {
                            plants[command[1]].Rarity = int.Parse(command[2]);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        if (plants.ContainsKey(command[1]))
                        {
                            for (int i = plants[command[1]].Rating.Count - 1; i >= 0; i--)
                            {
                                plants[command[1]].Rating.RemoveAt(i);
                            }
                            plants[command[1]].AverageRating = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.AverageRating))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.AverageRating:f2}");
            }
        }
    }
}
