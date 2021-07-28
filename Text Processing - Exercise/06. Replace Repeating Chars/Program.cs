using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < input.Length; i++)
            {
                if ((i != input.Length - 1) && (input[i] == input[i + 1]))
                {
                    input.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
