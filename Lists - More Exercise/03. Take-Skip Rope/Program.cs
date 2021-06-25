using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<char> encryptedList = new List<char>();
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                encryptedList.Add(encryptedMessage[i]);
            }
            List<char> numbers = new List<char>();
            for (int i = 0; i < encryptedList.Count; i++)
            {
                if (encryptedList[i] > 47 && encryptedList[i] < 58)
                {
                    numbers.Add(encryptedList[i]);
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                encryptedList.Remove(numbers[i]);
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(numbers[i].ToString()));
                }
                else
                {
                    skipList.Add(int.Parse(numbers[i].ToString()));
                }
            }
            string decryptedMessage = string.Empty;
            for (int i = 0; i < takeList.Count; i++)
            {
                int curentIndex = ReturnCorectIndex(takeList[i], encryptedList);
                for (int j = 0; j < curentIndex; j++)
                {
                    decryptedMessage += encryptedList[j];
                }
                RemoveChars(curentIndex, encryptedList);
                curentIndex = ReturnCorectIndex(skipList[i], encryptedList);
                RemoveChars(curentIndex, encryptedList);
            }
            Console.WriteLine(decryptedMessage);

        }

        private static int ReturnCorectIndex(int index, List<char> encryptedList)
        {
            if (index < 0)
            {
                return 0;
            }
            if (index >= encryptedList.Count)
            {
                return encryptedList.Count;
            }
            return index;
        }

        private static void RemoveChars(int v, List<char> encryptedList)
        {
            for (int j = v - 1; j >= 0; j--)
            {
                encryptedList.RemoveAt(j);
            }
        }
    }
}
