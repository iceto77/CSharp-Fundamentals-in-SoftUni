using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                bool isTrashesHedset = false;
                bool isTrashesMouse = false;
                bool isTrashesKeyboard = false;
                if (i % 2 == 0)
                {
                    isTrashesHedset = true;
                    headset++;
                }
                if (i % 3 == 0)
                {
                    isTrashesMouse = true;
                    mouse++;
                }
                if (isTrashesHedset && isTrashesMouse)
                {
                    isTrashesKeyboard = true;
                    keyboard++;
                }
                if (keyboard % 2 == 0 && keyboard > 0 && isTrashesKeyboard)
                {
                    display++;
                }
            }
            float totalSum = headset * headsetPrice + mouse * mousePrice + keyboard * keyboardPrice + display * displayPrice;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
