using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine().Split("|").ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "Yohoho!")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "Loot":
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (!treasureChest.Contains(command[i]))
                            {
                                treasureChest.Insert(0, command[i]);
                            }
                        }
                        break;
                    case "Drop":
                        int indexD = int.Parse(command[1]);
                        if (indexD >= 0 && indexD < treasureChest.Count)
                        {
                            string curentTreasure = treasureChest[indexD];
                            treasureChest.RemoveAt(indexD);
                            treasureChest.Add(curentTreasure);
                        }
                        break;
                    case "Steal":
                        int count = int.Parse(command[1]);
                        List<string> removedTreasure = new List<string>();
                        if (count >= treasureChest.Count)
                        {
                            for (int i = treasureChest.Count - 1; i >= 0; i--)
                            {
                                removedTreasure.Insert(0, treasureChest[i]);
                                treasureChest.RemoveAt(i);
                            }
                        }
                        else
                        {
                            int index = treasureChest.Count - 1;
                            for (int i = index; i > index - count; i--)
                            {
                                removedTreasure.Insert(0, treasureChest[i]);
                                treasureChest.RemoveAt(i);
                            }
                        }
                        Console.WriteLine(string.Join(", ", removedTreasure));
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            double averageGain = 0;
            if (treasureChest.Count < 1)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                for (int i = 0; i < treasureChest.Count; i++)
                {
                    averageGain += treasureChest[i].Length;
                }
                averageGain /= treasureChest.Count * 1.0;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }

        }
    }
}

