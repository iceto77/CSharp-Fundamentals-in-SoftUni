using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegsNumber = int.Parse(Console.ReadLine());
            float bestKegsVolume = 0f;
            string bestKegsType = "";
            for (int i = 0; i < kegsNumber; i++)
            {
                string kegType = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                float kegVolume = (float)Math.PI * kegRadius * kegRadius * kegHeight;
                if (kegVolume > bestKegsVolume)
                {
                    bestKegsVolume = kegVolume;
                    bestKegsType = kegType;
                }
            }
            Console.WriteLine(bestKegsType);
        }
    }
}
