using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Car
    {
        public Car(int mileage, int fuel)
        {
            Mileage = mileage;
            Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int carNum = int.Parse(Console.ReadLine());
            Dictionary<string, Car> needForSpeed = new Dictionary<string, Car>();
            string input = string.Empty;
            for (int i = 0; i < carNum; i++)
            {
                input = Console.ReadLine();
                string[] curentCar = input.Split("|").ToArray();
                if (!needForSpeed.ContainsKey(curentCar[0]))
                {
                    needForSpeed.Add(curentCar[0], new Car(int.Parse(curentCar[1]), int.Parse(curentCar[2])));
                }
            }
            input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] command = input.Split(" : ").ToArray();
                switch (command[0])
                {
                    case "Drive":
                        int neededFuel = int.Parse(command[3]);
                        int distance = int.Parse(command[2]);
                        //if (needForSpeed.ContainsKey(command[1]))
                        //{
                            if (needForSpeed[command[1]].Fuel >= neededFuel)
                            {
                                needForSpeed[command[1]].Fuel -= neededFuel;
                                needForSpeed[command[1]].Mileage += distance;
                                Console.WriteLine($"{command[1]} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                            }
                            if (needForSpeed[command[1]].Mileage > 100000)
                            {
                                Console.WriteLine($"Time to sell the {command[1]}!");
                                needForSpeed.Remove(command[1]);
                            }
                        //}
                        break;
                    case "Refuel":
                        int refillFuel = int.Parse(command[2]);
                        //if (needForSpeed.ContainsKey(command[1]))
                        //{
                            if (needForSpeed[command[1]].Fuel + refillFuel > 75)
                            {
                                refillFuel = 75 - needForSpeed[command[1]].Fuel;
                            }
                            needForSpeed[command[1]].Fuel += refillFuel;
                            Console.WriteLine($"{command[1]} refueled with {refillFuel} liters");
                        //}
                        break;
                    case "Revert":
                        int decrease = int.Parse(command[2]);
                        if (needForSpeed[command[1]].Mileage - decrease < 10000)
                        {
                            needForSpeed[command[1]].Mileage = 10000;
                        }
                        else
                        {
                            needForSpeed[command[1]].Mileage -= decrease;
                            Console.WriteLine($"{command[1]} mileage decreased by {decrease} kilometers");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in needForSpeed.OrderByDescending(x => x.Value.Mileage).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}
