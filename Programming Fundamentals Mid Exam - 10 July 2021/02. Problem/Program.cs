using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteGenres = Console.ReadLine().Split(" | ").ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "Stop!")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "Join":
                        if (!favoriteGenres.Contains(command[1]))
                        {
                            favoriteGenres.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (favoriteGenres.Contains(command[1]))
                        {
                            favoriteGenres.Remove(command[1]);
                        }
                        break;
                    case "Replace":
                        if (favoriteGenres.Contains(command[1]) && !favoriteGenres.Contains(command[2]))
                        {
                            for (int i = 0; i < favoriteGenres.Count; i++)
                            {
                                if (favoriteGenres[i] == command[1])
                                {
                                    favoriteGenres[i] = command[2];
                                    break;
                                }
                            }
                        }
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", favoriteGenres));
        }
    }
}
