using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYield = uint.Parse(Console.ReadLine());
            uint spiceExtracted = 0;
            uint daysOfOperation = 0;
            while (startingYield >= 100)
            {
                spiceExtracted += startingYield - 26;
                daysOfOperation++;
                startingYield -= 10;
            }
            if (spiceExtracted >= 26)
            {
                spiceExtracted -= 26;
            }
            Console.WriteLine(daysOfOperation);
            Console.WriteLine(spiceExtracted);
        }
    }
}
