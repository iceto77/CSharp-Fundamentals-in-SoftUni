using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSetQuality = Console.ReadLine().Split()
                .Select(int.Parse).ToList();
            string inputCommand = Console.ReadLine();
            List<int> curentDrumSetQuality = new List<int>();
            for (int i = 0; i < drumSetQuality.Count; i++)
            {
                curentDrumSetQuality.Add(drumSetQuality[i]);
            }
            while (inputCommand != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(inputCommand);
                for (int i = 0; i < curentDrumSetQuality.Count; i++)
                {
                    curentDrumSetQuality[i] -= hitPower;
                    if (curentDrumSetQuality[i] <= 0)
                    {
                        if ((double)(drumSetQuality[i] * 3) > savings)
                        {
                            curentDrumSetQuality[i] = 0;
                        }
                        else
                        {
                            curentDrumSetQuality[i] = drumSetQuality[i];
                            savings -= drumSetQuality[i] * 3;
                        }

                    }
                }
                inputCommand = Console.ReadLine();
            }
            for (int i = curentDrumSetQuality.Count - 1; i >= 0; i--)
            {
                if (curentDrumSetQuality[i] == 0)
                {
                    curentDrumSetQuality.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(" ", curentDrumSetQuality));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
