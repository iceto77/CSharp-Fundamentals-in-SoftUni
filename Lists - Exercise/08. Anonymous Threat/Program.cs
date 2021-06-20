using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split().ToList();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "3:1")
            {
                string[] commandArg = inputCommand.Split();

                if (commandArg[0] == "merge")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > inputText.Count - 1)
                    {
                        endIndex = inputText.Count - 1;
                    }
                    if (startIndex >= endIndex)
                    {
                        inputCommand = Console.ReadLine();
                        continue;
                    }
                    string curentText = string.Empty;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        curentText += inputText[i];
                        inputText[i] = string.Empty;
                    }
                    inputText[startIndex] = curentText;
                    int count = 0;
                    while (count != inputText.Count)
                    {
                        if (inputText[count] == string.Empty)
                        {
                            inputText.RemoveAt(count);
                            count--;
                        }
                        count++;
                    }
                }
                else if (commandArg[0] == "divide")
                {
                    int index = int.Parse(commandArg[1]);
                    int partitions = int.Parse(commandArg[2]);
                    int partitionLenght = inputText[index].Length / partitions;
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string curentText = inputText[index + i];
                        string tempText = string.Empty;
                        string newText = string.Empty;
                        for (int j = 0; j < partitionLenght; j++)
                        {
                            tempText += curentText[j];
                        }
                        for (int j = partitionLenght; j < curentText.Length; j++)
                        {
                            newText += curentText[j];
                        }
                        inputText[index + i] = newText;
                        inputText.Insert(index + i, tempText);
                    }
                }


                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputText));
        }
    }
}
