using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] coordinates = new int[fieldSize];
            int[] startingCoordinates = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
            for (int i = 0; i < startingCoordinates.Length; i++)
            {
                if (startingCoordinates[i] < 0 || startingCoordinates[i] >= coordinates.Length)
                {
                    continue;
                }
                else
                {
                coordinates[startingCoordinates[i]] = 1;                        
                }
            }
            string order = Console.ReadLine();
            while (order != "end")
            {
                string[] curentOrder = order.Split().ToArray();
                int targerCoordinate = int.Parse(curentOrder[0]);
                string direction = curentOrder[1];
                int moves = int.Parse(curentOrder[2]);
                int newCoordinates = 0;
                if (targerCoordinate >= 0 && targerCoordinate < coordinates.Length && coordinates[targerCoordinate] == 1)
                {
                    if (direction == "right")
                    {
                        coordinates[targerCoordinate] = 0;
                        newCoordinates = targerCoordinate + moves;
                        while (newCoordinates < coordinates.Length && newCoordinates >= 0 && coordinates[newCoordinates] == 1)
                        {
                            newCoordinates += moves;
                        }
                        if (newCoordinates >= 0 && newCoordinates < coordinates.Length)
                        {
                            coordinates[newCoordinates] = 1;
                        }
                    }
                    else if ((direction == "left"))
                    {
                        coordinates[targerCoordinate] = 0;
                        newCoordinates = targerCoordinate - moves;
                        while (newCoordinates >= 0 && newCoordinates < coordinates.Length && coordinates[newCoordinates] == 1)
                        {
                            newCoordinates-= moves;
                        }
                        if (newCoordinates >= 0 && newCoordinates < coordinates.Length)
                        {
                            coordinates[newCoordinates] = 1;
                        }
                    }
                }
                order = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", coordinates));
        }
    }
}
