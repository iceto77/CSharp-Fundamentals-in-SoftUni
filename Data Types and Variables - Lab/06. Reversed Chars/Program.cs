using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputs = new char[3];
            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = char.Parse(Console.ReadLine());
            }
            for (int i = inputs.Length - 1; i >= 0; i--)
            {
                Console.Write($"{inputs[i]} ");
            }
        }
    }
}
