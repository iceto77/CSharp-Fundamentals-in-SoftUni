using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            List<Box> storage = new List<Box>();
            List<Item> itemData = new List<Item>();
            while (inputs != "end")
            {
                string[] receivingData = inputs.Split().ToArray();
                Item curentItem = new Item(receivingData[1], double.Parse(receivingData[3]));
                itemData.Add(curentItem);
                double curentBoxPrice = double.Parse(receivingData[2]) * double.Parse(receivingData[3]);
                Box curentBox = new Box(int.Parse(receivingData[0]), itemData[itemData.Count - 1], int.Parse(receivingData[2]), curentBoxPrice);
                storage.Add(curentBox);
                inputs = Console.ReadLine();
            }
            OrdedBoxesByPrice(storage);
            PrintStorage(storage);

        }

        private static void PrintStorage(List<Box> storage)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                storage[i].PrintBox();
            }
        }

        private static void OrdedBoxesByPrice(List<Box> storage)
        {
            for (int i = 0; i < storage.Count; i++)
            {
                double maxValue = storage[i].Price;
                int maxIndex = i;
                for (int j = i; j < storage.Count; j++)
                {
                    double curentValue = storage[j].Price;
                    if (curentValue > maxValue)
                    {
                        maxValue = curentValue;
                        maxIndex = j;
                    }

                }
                Box tempValue = storage[i];
                storage[i] = storage[maxIndex];
                storage[maxIndex] = tempValue;
            }
        }
    }
}
