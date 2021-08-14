using System;
using System.Linq;
using System.Text;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder userName = new StringBuilder(input);
            input = Console.ReadLine();
            while (input != "Sign up")
            {
                string[] command = input.Split().ToArray();
                switch (command[0])
                {
                    case "Case":
                        string tempText = userName.ToString();
                        if (command[1] == "lower")
                        {
                            string lowerText = tempText.ToLower();
                            userName.Replace(tempText, lowerText);
                        }
                        else if (command[1] == "upper")
                        {
                            string upperText = tempText.ToUpper();
                            userName.Replace(tempText, upperText);
                        }
                        Console.WriteLine(userName);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        if (IsValidIndexes(startIndex, endIndex, userName))
                        {
                            string tempSubstring = string.Empty;
                            for (int i = endIndex; i >= startIndex; i--)
                            {
                                tempSubstring += userName[i];
                            }
                            Console.WriteLine(tempSubstring);
                        }
                        break;
                    case "Cut":
                        string temp = userName.ToString();
                        if (temp.Contains(command[1]))
                        {
                            int removeIndex = temp.IndexOf(command[1]);
                            userName.Remove(removeIndex, command[1].Length);
                            Console.WriteLine(userName);
                        }
                        else
                        {
                            Console.WriteLine($"The word {userName} doesn't contain {command[1]}.");
                        }
                        break;
                    case "Replace":
                        userName.Replace(command[1], "*");
                        Console.WriteLine(userName);
                        break;
                    case "Check":
                        string validation = userName.ToString();
                        if (validation.Contains(command[1]))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {command[1]}.");    
                        }
                        break;
                }
                input = Console.ReadLine();
            }

        }

        private static bool IsValidIndexes(int startIndex, int endIndex, StringBuilder userName)
        {
            if ((startIndex >= 0 && startIndex < userName.Length) && (endIndex >= 0 && endIndex < userName.Length && endIndex >= startIndex ))
            {
                return true;
            }
            return false;
        }
    }
}