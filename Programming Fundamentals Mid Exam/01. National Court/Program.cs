using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesEfficiency = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                employeesEfficiency += int.Parse(Console.ReadLine());
            }
            int peopleCount = int.Parse(Console.ReadLine());
            int neededTime = 0;
            int workingTime = 0;
            while (peopleCount > 0)
            {
                if (workingTime % 3 == 0 && workingTime > 0)
                {
                    neededTime++;
                    workingTime = 0;
                }
                else
                {
                    peopleCount -= employeesEfficiency;
                    neededTime++;
                    workingTime++;
                }
            }
            Console.WriteLine($"Time needed: {neededTime}h.");
        }
    }
}
