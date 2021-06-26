using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> Students = new List<Student>();
            while (input != "end")
            {
                List<string> inputData = input.Split().ToList();
                Students.Add(new Student(inputData[0], inputData[1], int.Parse(inputData[2]), inputData[3]));
                input = Console.ReadLine();
            }
            string town = Console.ReadLine();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Hometown == town)
                {
                    Students[i].PrintStudentInfo();
                }
            }
        }
    }
}
