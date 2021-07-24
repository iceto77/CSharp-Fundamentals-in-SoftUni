using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                string[] command = inputCommand.Split(" -> ").ToArray();
                if (!companyUsers.ContainsKey(command[0]))
                {
                    companyUsers.Add(command[0], new List<string>());
                }
                if (!companyUsers[command[0]].Contains(command[1]))
                {
                    companyUsers[command[0]].Add(command[1]);
                }
                inputCommand = Console.ReadLine();
            }
            foreach (var (key, value) in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);
                foreach (var item in value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
