using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split()
                            .Select(int.Parse).ToArray();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "End")
            {
                int indexOfTarget = int.Parse(inputCommand);
                if (indexOfTarget < targets.Length)
                {
                    int curentValue = targets[indexOfTarget];
                    if (targets[indexOfTarget] != -1)
                    {
                        targets[indexOfTarget] = -1;
                    }
                    if (curentValue != -1)
                    {
                        for (int i = 0; i < targets.Length; i++)
                        {
                            if (targets[i] != -1)
                            {
                                if (targets[i] > curentValue)
                                {
                                    targets[i] -= curentValue;
                                }
                                else
                                {
                                    targets[i] += curentValue;
                                }
                            }
                        }
                    }
                }
                inputCommand = Console.ReadLine();
            }
            int countOfShotTargets = 0;
            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    countOfShotTargets++;
                }
            }
            Console.Write($"Shot targets: {countOfShotTargets} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}
