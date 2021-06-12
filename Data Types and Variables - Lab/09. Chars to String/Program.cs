using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char textA = char.Parse(Console.ReadLine());
            char textB = char.Parse(Console.ReadLine());
            char textC = char.Parse(Console.ReadLine());
            Console.WriteLine(textA.ToString() + textB.ToString() + textC.ToString());
        }
    }
}
