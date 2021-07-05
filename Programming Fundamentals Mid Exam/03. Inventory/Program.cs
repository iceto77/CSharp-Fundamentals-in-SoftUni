using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = Console.ReadLine().Split(", ").ToList();
            string inputs = Console.ReadLine();
            while (inputs != "Craft!")
            {
                string[] command = inputs.Split(" - ").ToArray();
                 switch (command[0])
                {
                    case "Collect":
                        if (!collectingItems.Contains(command[1]))
                        {
                            collectingItems.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (collectingItems.Contains(command[1]))
                        {
                            collectingItems.Remove(command[1]);
                        }
                        break;
                    case "Combine Items":
                        string[] oldNewItem = command[1].Split(":");
                        for (int i = 0; i < collectingItems.Count; i++)
                        {
                            if (collectingItems[i] == oldNewItem[0])
                            {
                                collectingItems.Insert(i + 1, oldNewItem[1]);
                                break;
                            }
                        }
                        break;
                    case "Renew":
                        for (int i = 0; i < collectingItems.Count; i++)
                        {
                            if (collectingItems[i] == command[1])
                            {
                                string curentItem = collectingItems[i];
                                collectingItems.RemoveAt(i);
                                collectingItems.Add(curentItem);
                            }
                        }
                        break;
                }
                inputs = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", collectingItems));
        }
    }
}
