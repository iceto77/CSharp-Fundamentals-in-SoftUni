using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            StringBuilder resultDigit = new StringBuilder();
            StringBuilder resultLetter = new StringBuilder();
            StringBuilder resultOther = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    resultDigit.Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    resultLetter.Append(input[i]);
                }
                else
                {
                    resultOther.Append(input[i]);
                }
            }
            Console.WriteLine(resultDigit);
            Console.WriteLine(resultLetter);
            Console.WriteLine(resultOther);
        }
    }
}
