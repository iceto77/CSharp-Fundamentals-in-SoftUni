using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                string[] commandArg = inputCommand.Split().ToArray();
                switch (commandArg[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandArg[1]));
                        break;
                    case "Insert":
                        int insertIndex = int.Parse(commandArg[2]);
                        if (insertIndex < 0 || insertIndex >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            inputCommand = Console.ReadLine();
                            continue;
                        }
                        numbers.Insert(insertIndex, int.Parse(commandArg[1]));
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(commandArg[1]);
                        if (removeIndex < 0 || removeIndex >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            inputCommand = Console.ReadLine();
                            continue;
                        }
                        numbers.RemoveAt(removeIndex);
                        break;
                    case "Shift":
                        int count = int.Parse(commandArg[2]);
                        if (commandArg[1] == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int curentNum = numbers[0];
                                for (int j = 1; j < numbers.Count; j++)
                                {
                                    numbers[j - 1] = numbers[j];
                                }
                                numbers[numbers.Count - 1] = curentNum;
                            }
                        }
                        else if (commandArg[1] == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int curentNum = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = curentNum;
                            }
                        }
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
