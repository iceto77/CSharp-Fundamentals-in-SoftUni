using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                 .Select(int.Parse).ToList();
            List<int> beginNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                beginNumbers.Add(numbers[i]);
            }
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
                    case "Contains":
                        int requiredNum = int.Parse(commandArr[1]);
                        if (numbers.Contains(requiredNum))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", FindRequiredNumber(0, numbers)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", FindRequiredNumber(1, numbers)));
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        List<int> result = new List<int>();
                        int target = int.Parse(commandArr[2]);
                        switch (commandArr[1])
                        {
                            case "<":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] < target)
                                    {
                                        result.Add(numbers[i]);
                                    }
                                }
                                break;
                            case ">":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] > target)
                                    {
                                        result.Add(numbers[i]);
                                    }
                                }
                                break;
                            case ">=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] >= target)
                                    {
                                        result.Add(numbers[i]);
                                    }
                                }
                                break;
                            case "<=":
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] <= target)
                                    {
                                        result.Add(numbers[i]);
                                    }
                                }
                                break;
                        }
                        Console.WriteLine(string.Join(" ", result));
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            bool isTheSame = true;
            if (numbers.Count != beginNumbers.Count)
            {
                isTheSame = false;
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] != beginNumbers[i])
                    {
                        isTheSame = false;
                        break;
                    }
                }
            }
            if (!isTheSame)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static List<int> FindRequiredNumber(int v, List<int> numbs)
        {
            List<int> oddEvenNums = new List<int>();
            for (int i = 0; i < numbs.Count; i++)
            {
                if (numbs[i] % 2 == v)
                {
                    oddEvenNums.Add(numbs[i]);
                }
            }
            return oddEvenNums;
        }
    }
}
