using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputGrade = double.Parse(Console.ReadLine());
            Grade(inputGrade);
        }

        static void Grade(double grade)
        {
            if (grade < 2.00 || grade > 6.00)
            {
                Console.WriteLine("This grade is incorect!");
            }
            else if (grade < 3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
