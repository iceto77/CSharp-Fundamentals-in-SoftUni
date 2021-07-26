using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceBook = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                string[] command = new string[2];
                string forceSide = string.Empty;
                string forceUser = string.Empty;
                if (input.Contains('|'))
                {
                    command = input.Split(" | ").ToArray();
                    forceSide = command[0];
                    forceUser = command[1];
                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }
                    if (!forceBook[forceSide].Contains(forceUser) && !forceBook.Values.Any(x => x.Contains(forceUser)))
                    {
                        forceBook[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains("->"))
                {
                    command = input.Split(" -> ").ToArray();
                    forceSide = command[1];
                    forceUser = command[0];
                    foreach (var item in forceBook)
                    {
                        foreach (var user in item.Value)
                        {
                            if (user == forceUser)
                            {
                                item.Value.Remove(forceUser);
                                break;
                            }
                        }
                    }
                    if (!forceBook.ContainsKey(forceSide))
                    {
                        forceBook.Add(forceSide, new List<string>());
                    }
                    forceBook[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                input = Console.ReadLine();
            }
            foreach (var item in forceBook
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                foreach (var names in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {names}");
                }

            }
        }
    }
}
