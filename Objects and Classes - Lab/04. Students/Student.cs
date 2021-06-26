using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Students
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
    }
}
