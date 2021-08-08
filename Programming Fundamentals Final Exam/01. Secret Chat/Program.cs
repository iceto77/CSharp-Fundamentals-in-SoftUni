using System;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                //string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] command = input.Split(":|:").ToArray();
                switch (command[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index < message.Length)
                        {
                            message.Insert(index, (char)32);
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reverse":

                        if (IsContainsSubstring(command[1], message.ToString()))
                        {
                            string curentText = message.ToString();
                            string target = command[1];
                            int startIndex = curentText.IndexOf(target);
                            string leftText = curentText.Substring(0, startIndex);
                            string rightText = curentText.Substring(startIndex + target.Length);
                            message.Clear();
                            message.Append(leftText);
                            message.Append(rightText);
                            StringBuilder newSubtext = new StringBuilder();
                            for (int i = target.Length - 1; i >= 0; i--)
                            {
                                newSubtext.Append(target[i]);
                            }
                            message.Append(newSubtext.ToString());
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                        break;
                    case "ChangeAll":
                        if (IsContainsSubstring(command[1], message.ToString()))
                        {
                            while (IsContainsSubstring(command[1], message.ToString()))
                            {
                                message.Replace(command[1], command[2]);
                            }
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }

        private static bool IsContainsSubstring(string target, string message)
        {
            if (message.Contains(target))
            {
                return true;
            }
            return false;
        }
    }
}