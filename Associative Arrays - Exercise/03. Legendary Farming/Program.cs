using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = string.Empty;
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            var junk = new SortedDictionary<string, int>();
            bool isFinish = false;
            while (!isFinish)
            {
                inputCommand = Console.ReadLine().ToLower();
                string[] items = inputCommand.Split().ToArray();
                int quantity = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(items[i]);
                    }
                    else
                    {
                        switch (items[i])
                        {
                            case "shards":
                            case "fragments":
                            case "motes":
                                isFinish = AddKeyMaterials(items[i], quantity, keyMaterials);
                                break;
                            default:
                                AddJunk(items[i], quantity, junk);
                                break;
                        }
                    }
                    if (isFinish)
                    {
                        break;
                    }
                }
            }
            //keyMaterials.Values.OrderByDescending();
            foreach (var (key, value) in keyMaterials.OrderByDescending(x => x.Value).ThenBy( x => x.Key))
            {
                Console.WriteLine($"{key}: {value}");
            }
            foreach (var (key, value) in junk)
            {
                Console.WriteLine($"{key}: {value}");
            }
        }

        private static void AddJunk(string material, int quantity, SortedDictionary<string, int> junk)
        {
            if (!junk.ContainsKey(material))
            {
                junk.Add(material, quantity);
            }
            else
            {
                junk[material] += quantity;
            }
        }

        private static bool AddKeyMaterials(string material, int quantity, Dictionary<string, int> keyMaterials)
        {
            keyMaterials[material] += quantity;
            if (keyMaterials[material] >= 250)
            {
                keyMaterials[material] -= 250;
                string keyMaterial = string.Empty;
                switch (material)
                {
                    case "shards":
                        keyMaterial = "Shadowmourne";
                        break;
                    case "fragments":
                        keyMaterial = "Valanyr";
                        break;
                    case "motes":
                        keyMaterial = "Dragonwrath";
                        break;
                }
                Console.WriteLine($"{keyMaterial} obtained!");
                return true;
            }
            return false;
        }
    }
}
