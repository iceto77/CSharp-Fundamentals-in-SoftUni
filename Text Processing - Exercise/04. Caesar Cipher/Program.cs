using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                input[i] += (char)3;
            }
            Console.WriteLine(input);
        }
    }
}
