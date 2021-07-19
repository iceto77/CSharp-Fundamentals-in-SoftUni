using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcesCollector = new Dictionary<string, int>();
            string inputCommand = Console.ReadLine();
            int lineCount = 1;
            string item = string.Empty;
            while (inputCommand != "stop")
            {
                if (lineCount % 2 != 0)
                {
                    item = inputCommand;
                }
                else
                {
                    if (!resourcesCollector.ContainsKey(item))
                    {
                        resourcesCollector.Add(item, int.Parse(inputCommand));
                    }
                    else
                    {
                        resourcesCollector[item] += int.Parse(inputCommand);
                    }
                }
                inputCommand = Console.ReadLine();
                lineCount++;
            }
            foreach (var (resource, quantity) in resourcesCollector)
            {
                Console.WriteLine($"{resource} -> {quantity}");
            }
        }
    }
}
