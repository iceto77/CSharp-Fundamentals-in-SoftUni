using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputMeters = decimal.Parse(Console.ReadLine());
            decimal outputKilometers = inputMeters / 1000M;
            Console.WriteLine($"{outputKilometers:f2}");
        }
    }
}
