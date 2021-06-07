using System;

namespace _803.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling((double)persons / capacity));

            //първи вариант
            //int persons = int.Parse(Console.ReadLine());
            //int capacity = int.Parse(Console.ReadLine());
            //int neededCourses = persons / capacity;
            //if (persons % capacity != 0)
            //{
            //    neededCourses++;
            //}
            //Console.WriteLine(neededCourses);
        }
    }
}
