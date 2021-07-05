using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> neighborhood = Console.ReadLine().Split("@")
                .Select(byte.Parse).ToList();
            string inputCommand = Console.ReadLine();
            byte cupidPosition = 0;
            while (inputCommand != "Love!")
            {
                string[] curentCommand = inputCommand.Split().ToArray();
                byte jumpLength = byte.Parse(curentCommand[1]);
                cupidPosition += jumpLength;
                if (cupidPosition >= neighborhood.Count)
                {
                    cupidPosition = 0;
                }
                if (neighborhood[cupidPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidPosition} already had Valentine's day.");
                }
                else
                {
                    neighborhood[cupidPosition] -= 2;
                    if (neighborhood[cupidPosition] == 0)
                    {
                        Console.WriteLine($"Place {cupidPosition} has Valentine's day.");
                    }
                }

                inputCommand = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");
            byte faledCount = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] != 0)
                {
                    faledCount++;
                }
            }
            if (faledCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {faledCount} places.");  
            }

        }
    }
}
