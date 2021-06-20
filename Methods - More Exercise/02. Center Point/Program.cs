using System;
using System.Numerics;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double coordinateX1 = double.Parse(Console.ReadLine());
            double coordinateY1 = double.Parse(Console.ReadLine());
            double coordinateX2 = double.Parse(Console.ReadLine());
            double coordinateY2 = double.Parse(Console.ReadLine());
            double point1 = FindPoint(Math.Abs(coordinateX1), Math.Abs(coordinateY1));
            double point2 = FindPoint(Math.Abs(coordinateX2), Math.Abs(coordinateY2));
            if (point1 > point2)
            {
                Console.WriteLine($"({coordinateX2}, {coordinateY2})");
            }
            else
            {
                Console.WriteLine($"({coordinateX1}, {coordinateY1})");
            }
        }

        static double FindPoint(double xCoordinate, double yCoordinate)
        {
            double result = Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2);
            return Math.Sqrt(result);
        }
    }
}
