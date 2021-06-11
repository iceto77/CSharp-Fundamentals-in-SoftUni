using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());
            int count = range;
            do
            {
                int result = num * count;
                Console.WriteLine($"{num} X {count} = {result}");
                count++;
            }
            while (count <= 10);
        }
    }
}
