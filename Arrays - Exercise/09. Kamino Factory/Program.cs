using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthDNA = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            int[] bestDNA = new int[lengthDNA];
            int bestSequense = 0;
            int bestSum = 0;
            int bestIndex = 0;
            int sequenseNumber = 0;
            int topSequence = 0;
            while (order != "Clone them!")
            {
                int[] curentDNA = order.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                sequenseNumber++;
                int curentSequence = 0;
                int curentSum = curentDNA[curentDNA.Length - 1];
                int curentIndex = 0;
                int sequence = 0;
                int index = 0;
                for (int i = 0; i < curentDNA.Length - 1; i++)
                {
                    curentSum += curentDNA[i];
                    if (curentDNA[i] == curentDNA[i + 1])
                    {
                        if (sequence == 0)
                        {
                            index = i;
                        }
                        sequence++;
                    }
                    else
                    {
                        sequence = 0;
                    }
                    if (sequence > curentSequence)
                    {
                        curentSequence = sequence;
                        curentIndex = index;
                    }
                }
                if (curentSequence > bestSequense)
                {
                    bestSequense = curentSequence;
                    bestIndex = curentIndex;
                    topSequence = sequenseNumber;
                    bestSum = curentSum;
                    bestDNA = curentDNA;                    
                }
                else if (curentSequence == bestSequense && curentIndex < bestIndex)
                {
                    bestSequense = curentSequence;
                    bestIndex = curentIndex;
                    topSequence = sequenseNumber;
                    bestSum = curentSum;
                    bestDNA = curentDNA;
                }
                else if (curentSequence == bestSequense && curentIndex == bestIndex && curentSum > bestSum)
                {
                    bestSequense = curentSequence;
                    bestIndex = curentIndex;
                    topSequence = sequenseNumber;
                    bestSum = curentSum;
                    bestDNA = curentDNA;
                }
                order = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {topSequence} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}


// curentIndex = order.IndexOf("1");