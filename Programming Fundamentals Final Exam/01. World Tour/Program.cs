using System;
using System.Linq;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder travelStops = new StringBuilder(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] command = input.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Add Stop":
                        int index = int.Parse(command[1]);
                        travelStops.Insert(index, command[2]);
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int length = endIndex - startIndex + 1;
                        travelStops = travelStops.Remove(startIndex, length);
                        break;
                    case "Switch":
                        travelStops.Replace(command[1], command[2]);
                        break;
                }
                Console.WriteLine(travelStops);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {travelStops}");
        }
    }
}
