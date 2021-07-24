using System;
using System.Collections.Generic;
using System.Linq;


namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, double> studentAcademy = new Dictionary<string, double>();
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentAcademy.ContainsKey(name))
                {
                    studentAcademy.Add(name, grade);
                }
                else
                {
                    studentAcademy[name] += grade;
                    studentAcademy[name] /= 2.0;
                }
            }
            foreach (var item in studentAcademy)
            {
                if (item.Value < 4.50)
                {
                    studentAcademy.Remove(item.Key);
                }
            }
            foreach (var (name, averageGrade) in studentAcademy.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{name} -> {averageGrade:f2}");
            }
        }
    }
}
