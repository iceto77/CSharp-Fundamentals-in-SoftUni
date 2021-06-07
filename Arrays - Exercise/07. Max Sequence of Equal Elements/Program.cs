using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split()
                            .Select(int.Parse).ToArray();
            int index = 0;
            int bestLongestSequence = 0;
            int bestLongestSequenceValue = 0;
            int longestSequence = 1;
            int longestSequenceValue = 0;
            while (index < inputNumbers.Length - 1)
            {
                if (inputNumbers[index] == inputNumbers[index + 1])
                {
                    longestSequence++;
                    longestSequenceValue = inputNumbers[index];
                }
                else
                {
                    longestSequence = 1;
                    longestSequenceValue = 0;
                }

                if (longestSequence > bestLongestSequence)
                {
                    bestLongestSequence = longestSequence;
                    bestLongestSequenceValue = longestSequenceValue;
                }
                index++;
            }
            for (int i = 0; i < bestLongestSequence; i++)
            {
                Console.Write($"{bestLongestSequenceValue} ");
            }
        }
    }
}
