using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._List_Manipulation_Basics
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
                string[] commandArr = inputCommand.Split().ToArray();
                switch (commandArr[0])
                {
                    case "Add":
                        int indexA = int.Parse(commandArr[1]);
                        numbers.Add(indexA);
                        break;
                    case "Remove":
                        int indexR = int.Parse(commandArr[1]);
                        numbers.Remove(indexR);
                        break;
                    case "RemoveAt":
                        int indexRA = int.Parse(commandArr[1]);
                        numbers.RemoveAt(indexRA);
                        break;
                    case "Insert":
                        int number = int.Parse(commandArr[1]);
                        int indexI = int.Parse(commandArr[2]);
                        numbers.Insert(indexI, number);
                        break;
                }
                        inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
