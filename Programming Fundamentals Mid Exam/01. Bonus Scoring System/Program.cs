using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendance = 0;
            for (int i = 0; i < students; i++)
            {
                int curentCountOfAttendances = int.Parse(Console.ReadLine());
                double totalBonus = 1.0 * curentCountOfAttendances / lectures * (5 + initialBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = curentCountOfAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
