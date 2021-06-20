using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coursePlanning = Console.ReadLine().Split(", ").ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "course start")
            {
                List<string> commandArg = inputCommand.Split(':').ToList();
                switch (commandArg[0])
                {
                    case "Add":
                        if (!coursePlanning.Contains(commandArg[1]))
                        {
                            coursePlanning.Add(commandArg[1]);
                        }
                        break;
                    case "Insert":
                        if (!coursePlanning.Contains(commandArg[1]))
                        {
                            int index = int.Parse(commandArg[2]);
                            coursePlanning.Insert(index, commandArg[1]);
                        }
                        break;
                    case "Remove":
                        if (coursePlanning.Contains(commandArg[1]))
                        {
                            coursePlanning.Remove(commandArg[1]);
                            if (coursePlanning.Contains(commandArg[1] + "-Exercise"))
                            {
                                coursePlanning.Remove(commandArg[1] + "-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                        //Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any, which follow the lessons
                        if (coursePlanning.Contains(commandArg[1]) && coursePlanning.Contains(commandArg[2]))
                        {
                            string[] tempText = new string[2];
                            int[] tempIndex = new int[2];
                            bool[] isExist = new bool[2];
                            if (coursePlanning.Contains(commandArg[1] + "-Exercise"))
                            {
                                isExist[0] = true;
                                coursePlanning.Remove(commandArg[1] + "-Exercise");
                            }
                            if (coursePlanning.Contains(commandArg[2] + "-Exercise"))
                            {
                                isExist[1] = true;
                                coursePlanning.Remove(commandArg[2] + "-Exercise");
                            }
                            for (int i = 0; i < coursePlanning.Count; i++)
                            {
                                if (coursePlanning[i] == commandArg[1])
                                {
                                    tempIndex[0] = i;
                                    tempText[0] = coursePlanning[i];
                                }
                                if (coursePlanning[i] == commandArg[2])
                                {
                                    tempIndex[1] = i;
                                    tempText[1] = coursePlanning[i];
                                }
                            }
                            coursePlanning[tempIndex[0]] = tempText[1];
                            coursePlanning[tempIndex[1]] = tempText[0];
                            if (isExist[0])
                            {
                                coursePlanning.Insert(tempIndex[0] + 1, tempText[1] + "-Exercise");
                            }
                            if (isExist[1])
                            {
                                if (isExist[0])
                                {
                                    coursePlanning.Insert(tempIndex[1] + 2, tempText[0] + "-Exercise");
                                }
                                else
                                {
                                    coursePlanning.Insert(tempIndex[1] + 1, tempText[0] + "-Exercise");
                                }
                            }
                        }
                        break;
                    case "Exercise":
                        if (coursePlanning.Contains(commandArg[1]) && !coursePlanning.Contains(commandArg[1] + "-Exercise"))
                        {
                            for (int i = 0; i < coursePlanning.Count; i++)
                            {
                                if (coursePlanning[i] == commandArg[1])
                                {
                                    coursePlanning.Insert(i + 1, commandArg[1] + "-Exercise");
                                    break;
                                }
                            }
                        }
                        else if (!coursePlanning.Contains(commandArg[1]))
                        {
                            coursePlanning.Add(commandArg[1]);
                            coursePlanning.Add(commandArg[1] + "-Exercise");
                        }
                        break;
                    default:
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            for (int i = 0; i < coursePlanning.Count; i++)
            {
                Console.WriteLine($"{i+1}.{coursePlanning[i]}");
            }
        }
    }
}
