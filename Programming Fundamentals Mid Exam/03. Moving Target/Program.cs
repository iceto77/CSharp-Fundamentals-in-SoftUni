using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "Shoot":
                        int indexSh = int.Parse(command[1]);
                        int power = int.Parse(command[2]);
                        if (indexSh < targets.Count && indexSh >= 0)
                        {
                            targets[indexSh] -= power;
                        }
                        if (targets[indexSh] <= 0)
                        {
                            targets.RemoveAt(indexSh);
                        }
                        break;
                    case "Add":
                        int indexA = int.Parse(command[1]);
                        int value = int.Parse(command[2]);
                        if (indexA < targets.Count && indexA >= 0)
                        {
                            targets.Insert(indexA, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int indexSt = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);
                        if (indexSt + radius >= targets.Count || indexSt - radius < 0)
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        else
                        {
                            for (int i = indexSt + radius; i >= indexSt - radius; i--)
                            {
                                targets.RemoveAt(i);
                            }
                        }
                        break;
                }

                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
