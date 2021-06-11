using System;
using System.Globalization;

namespace _13._Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            int holidaysCount = 0;
            int count = 0;
            DateTime curentDate = startDate;
            while (curentDate <= endDate)
            {
                if (curentDate.DayOfWeek == DayOfWeek.Saturday || curentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
                count++;
                curentDate = curentDate.AddDays(1);
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
