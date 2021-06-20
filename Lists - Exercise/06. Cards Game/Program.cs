using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            bool isGameFinish = false;
            string winner = string.Empty;
            while (!isGameFinish)
            {
                int curentCard = 0;
                if (playerOne[0] > playerTwo[0])
                {
                    curentCard = playerOne[0];
                    for (int i = 1; i < playerOne.Count; i++)
                    {
                        playerOne[i - 1] = playerOne[i];
                    }
                    playerOne[playerOne.Count - 1] = curentCard;
                    playerOne.Add(playerTwo[0]);
                    playerTwo.RemoveAt(0);
                }
                else if (playerOne[0] < playerTwo[0])
                {
                    curentCard = playerTwo[0];
                    for (int i = 1; i < playerTwo.Count; i++)
                    {
                        playerTwo[i - 1] = playerTwo[i];
                    }
                    playerTwo[playerTwo.Count - 1] = curentCard;
                    playerTwo.Add(playerOne[0]);
                    playerOne.RemoveAt(0);
                }
                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                if (playerOne.Count == 0)
                {
                    isGameFinish = true;
                    winner = "Second";
                }
                if (playerTwo.Count == 0)
                {
                    isGameFinish = true;
                    winner = "First";
                }
            }
            int sum = 0;
            if (winner == "First")
            {
                for (int i = 0; i < playerOne.Count; i++)
                {
                    sum += playerOne[i];
                }
            }
            else if (winner == "Second")
            {
                for (int i = 0; i < playerTwo.Count; i++)
                {
                    sum += playerTwo[i];
                }
            }            
            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
