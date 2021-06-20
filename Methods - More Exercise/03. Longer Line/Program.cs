using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputs = new double[8];
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = double.Parse(Console.ReadLine());
            }

            double line1 = FindPoint(Math.Abs(inputs[0]) + Math.Abs(inputs[2]), Math.Abs(inputs[1]) + Math.Abs(inputs[3]));
            double line2 = FindPoint(Math.Abs(inputs[4]) + Math.Abs(inputs[6]), Math.Abs(inputs[5]) + Math.Abs(inputs[7]));
            if (line1 >= line2)
            {
                double point1 = FindPoint(Math.Abs(inputs[0]), Math.Abs(inputs[1]));
                double point2 = FindPoint(Math.Abs(inputs[2]), Math.Abs(inputs[3]));
                if (point1 > point2)
                {
                    Console.WriteLine($"({inputs[2]}, {inputs[3]})({inputs[0]}, {inputs[1]})"); ;
                }
                else
                {
                    Console.WriteLine($"({inputs[0]}, {inputs[1]})({inputs[2]}, {inputs[3]})");
                }
            }
            else
            {
                double point1 = FindPoint(Math.Abs(inputs[4]), Math.Abs(inputs[5]));
                double point2 = FindPoint(Math.Abs(inputs[6]), Math.Abs(inputs[7]));
                if (point1 > point2)
                {
                    Console.WriteLine($"({inputs[6]}, {inputs[7]})({inputs[4]}, {inputs[5]})"); ;
                }
                else
                {
                    Console.WriteLine($"({inputs[4]}, {inputs[5]})({inputs[6]}, {inputs[7]})");
                }
            }
        }

        static double FindPoint(double xCoordinate, double yCoordinate)
        {
            double result = Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2);
            return Math.Sqrt(result);
        }
    }
}
