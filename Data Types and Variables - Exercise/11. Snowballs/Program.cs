using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowballsNumber = byte.Parse(Console.ReadLine());
            ushort bestSnowballSnow = 0;
            ushort bestSnowballTime = 0;
            byte bestSnowballQuality = 0;
            BigInteger bestSnowballValue = 0;
            for (int i = 0; i < snowballsNumber; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine());
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue >= bestSnowballValue)
                {
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }
    }
}
