using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 0; i < commandsNumber; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "register":
                        if (parking.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[command[1]]}");
                        }
                        else
                        {
                            parking.Add(command[1], command[2]);
                            Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!parking.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"ERROR: user {command[1]} not found");
                        }
                        else
                        {
                            parking.Remove(command[1]);
                            Console.WriteLine($"{command[1]} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var (username, licensePlateNumber) in parking)
            {
                Console.WriteLine($"{username} => {licensePlateNumber}");
            }
        }
    }
}
