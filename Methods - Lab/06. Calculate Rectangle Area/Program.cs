using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double area = CalculatingAreaOfTriangle(firstSide, secondSide);
            Console.WriteLine(area);
        }

        static double CalculatingAreaOfTriangle(double sideA, double sideB)
        {
            return sideA * sideB;
        }
    }
}
