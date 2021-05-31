using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int poursNumber = int.Parse(Console.ReadLine());
            int usedTankCapacity = 0;
            for (int i = 0; i < poursNumber; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                usedTankCapacity += pour;
                if (usedTankCapacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    usedTankCapacity -= pour;
                }
            }
            Console.WriteLine(usedTankCapacity);
        }
    }
}
