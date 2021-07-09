using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            for (int i = 0; i < lift.Length; i++)
            {
                int emptyPositions = 4 - lift[i];
                if (waitingPeople >= emptyPositions)
                {
                    lift[i] += emptyPositions;
                    waitingPeople -= emptyPositions;
                }
                else
                {
                    lift[i] += waitingPeople;
                    waitingPeople = 0;
                    break;
                }
            }
            bool isLiftEmptySpots = false;
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] != 4)
                {
                    isLiftEmptySpots = true;
                    break;
                }
            }
            if (waitingPeople == 0 && isLiftEmptySpots)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ",lift));
            }
            else if (waitingPeople > 0 && !isLiftEmptySpots)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (waitingPeople == 0 && !isLiftEmptySpots)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
