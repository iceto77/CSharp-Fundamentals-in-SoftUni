using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatLogger = new List<string>();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "Chat":
                        chatLogger.Add(command[1]);
                        break;
                    case "Delete":
                        if (chatLogger.Contains(command[1]))
                        {
                            chatLogger.Remove(command[1]);
                        }
                        break;
                    case "Edit":
                        if (chatLogger.Contains(command[1]))
                        {
                            for (int i = 0; i < chatLogger.Count; i++)
                            {
                                if (chatLogger[i] == command[1])
                                {
                                    chatLogger[i] = command[2];
                                    break;
                                }
                            }
                        }
                        break;
                    case "Pin":
                        if (chatLogger.Contains(command[1]))
                        {
                            for (int i = 0; i < chatLogger.Count; i++)
                            {
                                if (chatLogger[i] == command[1])
                                {
                                    chatLogger.RemoveAt(i);
                                    chatLogger.Add(command[1]);
                                    break;
                                }
                            }
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < command.Length; i++)
                        {
                            chatLogger.Add(command[i]);
                        }
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", chatLogger));
        }
    }
}
