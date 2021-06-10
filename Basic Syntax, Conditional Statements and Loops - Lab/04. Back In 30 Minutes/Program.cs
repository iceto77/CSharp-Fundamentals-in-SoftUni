using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            minute += 30;
            if (minute > 59)
            {
                minute -= 60;
                hour++;
            }
            if (hour > 23)
            {
                hour -= 24;
            }
            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
