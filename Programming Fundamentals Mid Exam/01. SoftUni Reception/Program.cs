using System;

namespace _01._SoftUni_Reception
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
            int studentsCount = int.Parse(Console.ReadLine());
            int neededTime = 0;
            int workingTime = 0;
            while (studentsCount > 0)
            {
                if (workingTime % 3 == 0 && workingTime > 0)
                {
                    neededTime++;
                    workingTime = 0;
                }
                else
                {
                    studentsCount -= employeesEfficiency;
                    neededTime++;
                    workingTime++;
                }
            }
            Console.WriteLine($"Time needed: {neededTime}h.");
        }
    }
}
