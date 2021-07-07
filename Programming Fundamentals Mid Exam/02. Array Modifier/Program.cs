using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            string inputCommamd = Console.ReadLine();
            while (inputCommamd != "end")
            {
                string[] command = inputCommamd.Split().ToArray();
                switch (command[0])
                {
                    case "swap":
                        int fisrstIndex = int.Parse(command[1]);
                        int secondIndex = int.Parse(command[2]);
                        if (fisrstIndex >= 0 && fisrstIndex < numbers.Length)
                        {
                            if (secondIndex >= 0 && secondIndex < numbers.Length)
                            {
                                int temp = numbers[fisrstIndex];
                                numbers[fisrstIndex] = numbers[secondIndex];
                                numbers[secondIndex] = temp;
                            }
                        }
                        break;
                    case "multiply":
                        fisrstIndex = int.Parse(command[1]);
                        secondIndex = int.Parse(command[2]);
                        if (fisrstIndex >= 0 && fisrstIndex < numbers.Length)
                        {
                            if (secondIndex >= 0 && secondIndex < numbers.Length)
                            {
                                int temp = numbers[fisrstIndex] * numbers[secondIndex];
                                numbers[fisrstIndex] = temp;
                            }
                        }
                        break;
                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] -= 1; 
                        }
                        break;
                }
                inputCommamd = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
