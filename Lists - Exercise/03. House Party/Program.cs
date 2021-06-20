using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                bool isExist = false;
                string[] commandArg = Console.ReadLine().Split();
                for (int j = 0; j < guests.Count; j++)
                {
                    if (guests[j] == commandArg[0])
                    {
                        isExist = true;
                        break;
                    }
                }
                if (commandArg[2] == "going!" && !isExist)
                {
                    guests.Add(commandArg[0]);
                }
                else if (commandArg[2] == "going!" && isExist)
                {
                    Console.WriteLine($"{commandArg[0]} is already in the list!");
                }
                else if (commandArg[2] == "not" && !isExist)
                {
                    Console.WriteLine($"{commandArg[0]} is not in the list!");
                }
                else if (commandArg[2] == "not" && isExist)
                {
                    guests.Remove(commandArg[0]);
                }
            }       
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
