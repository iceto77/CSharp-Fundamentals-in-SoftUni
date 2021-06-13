using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] command = inputCommand.Split().ToArray();
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        if (index >= inputArr.Length || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            ExchangeArr(index, inputArr);
                        }
                        break;
                    case "max":
                        IndexOfMaxEvenOddElement(command[1], inputArr);
                        break;
                    case "min":
                        IndexOfMinEvenOddElement(command[1], inputArr);
                        break;
                    case "first":
                        FindFirstEvenOddElement(command[1], GetEvenOdd(command[2]), inputArr);
                        break;
                    case "last":
                        FindLastEvenOddElement(command[1], GetEvenOdd(command[2]), inputArr);
                        break;
                }
                inputCommand = Console.ReadLine();
            }
            PrintArray(inputArr);
        }

        private static void PrintArray(int[] curentArr)
        {
            Console.WriteLine($"[{string.Join(", ", curentArr)}]");
        }

        static int GetEvenOdd(string command)
        {
            int evenOdd = 0;
            if (command == "odd")
            {
                evenOdd = 1;
            }
            return evenOdd;
        }

        static void FindLastEvenOddElement(string elementNumber, int evenOdd, int[] inputArr)
        {
            int num = int.Parse(elementNumber);
            if (num > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int evenOddNumbersCount = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == evenOdd)
                {
                    evenOddNumbersCount++;
                }
            }
            if (num > evenOddNumbersCount)
            {
                num = evenOddNumbersCount;
            }
            int[] requiredNumbers = new int[num];
            int count = 0;
            for (int i = inputArr.Length - 1; i >= 0; i--)
            {
                if (inputArr[i] % 2 == evenOdd)
                {
                    requiredNumbers[num - count - 1] = inputArr[i];
                    count++;
                }
                if (count == num)
                {
                    PrintArray(requiredNumbers);
                    return;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                PrintArray(requiredNumbers);
            }
            return;
        }

        static void FindFirstEvenOddElement(string elementNumber, int evenOdd, int[] inputArr)
        {
            int num = int.Parse(elementNumber);
            if (num > inputArr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int evenOddNumbersCount = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == evenOdd)
                {
                    evenOddNumbersCount++;
                }
            }
            if (num > evenOddNumbersCount)
            {
                num = evenOddNumbersCount;
            }
            int[] requiredNumbers = new int[num];
            int count = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] % 2 == evenOdd)
                {
                    requiredNumbers[count] = inputArr[i];
                    count++;
                }
                if (count == num)
                {
                    PrintArray(requiredNumbers);
                    return;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                PrintArray(requiredNumbers);
            }
            return;
        }


        static void IndexOfMinEvenOddElement(string command, int[] inputArr)
        {
            int minNumber = int.MaxValue;
            int minIndex = int.MaxValue;
            if (command == "even")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        if (inputArr[i] <= minNumber)
                        {
                            minNumber = inputArr[i];
                            minIndex = i;
                        }
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        if (inputArr[i] <= minNumber)
                        {
                            minNumber = inputArr[i];
                            minIndex = i;
                        }
                    }
                }
            }
            if (minNumber == int.MaxValue)
            {
                Console.WriteLine("No matches");
                return;
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        static void IndexOfMaxEvenOddElement(string command, int[] inputArr)
        {
            int maxNumber = int.MinValue;
            int maxIndex = int.MinValue;
            if (command == "even")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        if (inputArr[i] >= maxNumber)
                        {
                            maxNumber = inputArr[i];
                            maxIndex = i;
                        }
                    }
                }
            }
            if (command == "odd")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        if (inputArr[i] >= maxNumber)
                        {
                            maxNumber = inputArr[i];
                            maxIndex = i;
                        }
                    }
                }
            }
            if (maxNumber == int.MinValue)
            {
                Console.WriteLine("No matches");
                return;
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void ExchangeArr(int index, int[] inputArr)
        {
            int[] lertfArr = new int[index + 1];
            int[] rightArr = new int[inputArr.Length - index - 1];
            int count = 0;
            for (int i = 0; i < lertfArr.Length; i++)
            {
                lertfArr[i] = inputArr[count];
                count++;
            }
            for (int i = 0; i < rightArr.Length; i++)
            {
                rightArr[i] = inputArr[count];
                count++;
            }
            for (int i = 0; i < rightArr.Length; i++)
            {
                inputArr[i] = rightArr[i];
            }
            for (int i = 0; i < lertfArr.Length; i++)
            {
                inputArr[rightArr.Length + i] = lertfArr[i];
            }
        }
    }
}

