using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            int wagonsMaxCapacity = int.Parse(Console.ReadLine());
            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] commandArg = inputCommand.Split();
                if (commandArg[0] == "Add")
                {
                    int newWagon = int.Parse(commandArg[1]);
                    train.Add(newWagon);
                }
                else
                {
                    int newPassengers = int.Parse(commandArg[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (newPassengers <= (wagonsMaxCapacity - train[i]))
                        {
                            train[i] += newPassengers;
                            break;
                        }
                    }
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
