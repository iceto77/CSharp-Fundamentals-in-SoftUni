using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            float lightsabersPrice = float.Parse(Console.ReadLine());
            float robesPrice = float.Parse(Console.ReadLine());
            float beltsPrice = float.Parse(Console.ReadLine());
            int beltsDiscount = studentsNumber / 6;
            double lightsabersAdditive = Math.Ceiling(1.1 * studentsNumber);
            float neededMoney = (float)lightsabersAdditive * lightsabersPrice + (studentsNumber - beltsDiscount) * beltsPrice + studentsNumber * robesPrice;
            if (amountOfMoney >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney - amountOfMoney:f2}lv more.");
            }
        }
    }
}
