using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            double halfStartingPower = pokePowerN / 2.0;
            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                targetsCount++;
                if (pokePowerN == halfStartingPower && exhaustionFactorY > 0)
                {
                    pokePowerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(targetsCount);
        }
    }
}
