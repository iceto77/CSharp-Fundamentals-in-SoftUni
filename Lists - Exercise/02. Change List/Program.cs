using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] commandArg = inputCommand.Split();
                int element = int.Parse(commandArg[1]);
                if (commandArg[0] == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(element);
                    }
                }
                if (commandArg[0] == "Insert")
                {
                    int position = int.Parse(commandArg[2]);
                    numbers.Insert(position, element);
                }


                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
