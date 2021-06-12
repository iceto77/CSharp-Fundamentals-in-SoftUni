using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char textA = char.Parse(Console.ReadLine());
            if (textA >= 65 && textA <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (textA >= 97 && textA <= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
