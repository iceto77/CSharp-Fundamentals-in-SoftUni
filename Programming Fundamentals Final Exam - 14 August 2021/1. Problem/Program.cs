using System;
using System.Linq;
using System.Text;

namespace _1._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder targetText = new StringBuilder(input);
            input = Console.ReadLine();
            while (input != "End")
            {
                string[] commands = input.Split().ToArray();
                string command = commands[0];
                switch (command)
                {
                    case "Translate":
                        string target = commands[1];
                        string replacement = commands[2];
                        targetText.Replace(target, replacement);
                        Console.WriteLine(targetText);
                        break;
                    case "Includes":
                        target = commands[1];
                        string curentText = targetText.ToString();
                        Console.WriteLine(curentText.Contains(target));
                        break;
                    case "Start":
                        target = commands[1];
                        bool isStart = true;
                        for (int i = 0; i < target.Length; i++)
                        {
                            if (targetText[i] != target[i])
                            {
                                isStart = false;
                                break;
                            }
                        }
                        Console.WriteLine(isStart);
                        break;
                    case "Lowercase":
                        target = targetText.ToString().ToLower();
                        targetText.Clear();
                        targetText.Append(target);
                        Console.WriteLine(targetText);
                        break;
                    case "FindIndex":
                        string searchingChar = commands[1];
                        target = targetText.ToString();
                        int index = target.LastIndexOf(searchingChar);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        int startIdex = int.Parse(commands[1]);
                        int count = int.Parse(commands[2]);
                        targetText.Remove(startIdex, count);
                        Console.WriteLine(targetText);
                        break;
                }
                input = Console.ReadLine();
            }

        }
    }
}
