using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0.0;
            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = peopleNumber * 8.45;
                            break;
                        case "Saturday":
                            totalPrice = peopleNumber * 9.80;
                            break;
                        case "Sunday":
                            totalPrice = peopleNumber * 10.46;
                            break;
                    }
                    if (peopleNumber >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    double price = 0.0;
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    if (peopleNumber >= 100)
                    {
                        totalPrice = (peopleNumber - 10) * price;
                    }
                    else
                    {
                        totalPrice = peopleNumber * price;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            totalPrice = peopleNumber * 15;
                            break;
                        case "Saturday":
                            totalPrice = peopleNumber * 20;
                            break;
                        case "Sunday":
                            totalPrice = peopleNumber * 22.50;
                            break;
                    }
                    if (peopleNumber >= 10 && peopleNumber <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
