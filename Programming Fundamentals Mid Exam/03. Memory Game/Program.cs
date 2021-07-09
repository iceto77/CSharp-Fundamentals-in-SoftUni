using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> memorySequence = Console.ReadLine().Split().ToList();
            string inputCommand = Console.ReadLine();
            int movesCount = 0;
            while (inputCommand != "end")
            {
                movesCount++;
                int[] gameMove = inputCommand.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                if ((gameMove[0] == gameMove[1])
                        || (gameMove[0] < 0 || gameMove[0] >= memorySequence.Count)
                                || (gameMove[1] < 0 || gameMove[1] >= memorySequence.Count))
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    AddTwoMatchingElements(movesCount, memorySequence);
                }
                else
                {
                    if (memorySequence[gameMove[0]] == memorySequence[gameMove[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {memorySequence[gameMove[0]]}!");
                        if (gameMove[0] > gameMove[1])
                        {
                            memorySequence.RemoveAt(gameMove[0]);
                            memorySequence.RemoveAt(gameMove[1]);
                        }
                        else
                        {
                            memorySequence.RemoveAt(gameMove[1]);
                            memorySequence.RemoveAt(gameMove[0]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                if (memorySequence.Count < 2)
                {
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    return;
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", memorySequence));

        }

        private static void AddTwoMatchingElements(int movesCount, List<string> memorySequence)
        {
            int midle = memorySequence.Count / 2;
            string newElement = $"-{movesCount}a";
            memorySequence.Insert(midle, newElement);
            memorySequence.Insert(midle, newElement);
        }
    }
}
