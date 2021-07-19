using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] coursesInfo = inputCommand.Split(" : ").ToArray();
                if (!courses.ContainsKey(coursesInfo[0]))
                {
                    courses.Add(coursesInfo[0], new List<string>());
                }
                if (!courses[coursesInfo[0]].Contains(coursesInfo[1]))
                {
                    courses[coursesInfo[0]].Add(coursesInfo[1]);
                }

                inputCommand = Console.ReadLine();
            }
            foreach (var (courseName, students) in courses.OrderByDescending(x => x.Value.Count))
            {
                int registeredStudents = students.Count;
                Console.WriteLine($"{courseName}: {registeredStudents}");
                //for (int i = 0; i < registeredStudents; i++)
                //{
                //    Console.WriteLine($"-- {students[i]}");
                //}
                foreach (var item in students.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
