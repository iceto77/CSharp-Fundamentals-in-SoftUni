using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < inputNumbers.Length - 1; j++)
                {
                    int lastNumber = inputNumbers[j];
                    inputNumbers[j] = inputNumbers[j + 1];
                    inputNumbers[j + 1] = lastNumber;
                }
            }
            Console.WriteLine(string.Join(" ",inputNumbers ));
        }
    }
}
