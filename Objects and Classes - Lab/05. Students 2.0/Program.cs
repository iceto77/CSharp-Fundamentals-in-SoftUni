using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Student
    {
        public Student(string firstName, string lasstName, int age, string hometown)
        {
            FirstName = firstName;
            LastName = lasstName;
            Age = age;
            Hometown = hometown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }


        public void PrintStudentInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} years old.");
        }

        public bool StidentExsisting(Student curentStudent)
        {
            if (FirstName == curentStudent.FirstName && LastName == curentStudent.LastName)
            {
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> Students = new List<Student>();
            while (input != "end")
            {
                List<string> inputData = input.Split().ToList();
                Student curentStudent = new Student(inputData[0], inputData[1], int.Parse(inputData[2]), inputData[3]);
                bool isExisting = false;
                for (int i = 0; i < Students.Count; i++)
                {
                    isExisting = Students[i].StidentExsisting(curentStudent);
                    if (isExisting)
                    {
                        break;
                    }
                }
                if (isExisting)
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        isExisting = Students[i].StidentExsisting(curentStudent);
                        if (isExisting)
                        {
                            Students[i].Age = curentStudent.Age;
                            Students[i].Hometown = curentStudent.Hometown;
                            break;
                        }
                    }
                }
                else
                {
                    Students.Add(curentStudent);
                }

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
