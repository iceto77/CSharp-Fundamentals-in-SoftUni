using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceryList = Console.ReadLine().Split("!").ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "Go Shopping!")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "Urgent":
                        if (!groceryList.Contains(command[1]))
                        {
                            groceryList.Insert(0, command[1]);
                        }
                        break;
                    case "Unnecessary":
                        if (groceryList.Contains(command[1]))
                        {
                            groceryList.Remove(command[1]);
                        }
                        break;
                    case "Correct":
                        if (groceryList.Contains(command[1]))
                        {
                            for (int i = 0; i < groceryList.Count; i++)
                            {
                                if (groceryList[i] == command[1])
                                {
                                    groceryList[i] = command[2];
                                    break;
                                }
                            }
                        }
                        break;
                    case "Rearrange":
                        if (groceryList.Contains(command[1]))
                        {
                            string curentGrocery = string.Empty;
                            for (int i = 0; i < groceryList.Count; i++)
                            {
                                if (groceryList[i] == command[1])
                                {
                                    curentGrocery = groceryList[i];
                                    groceryList.Remove(command[1]);
                                    break;
                                }
                            }
                            groceryList.Add(curentGrocery);
                        }
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceryList));
        }
    }
}
