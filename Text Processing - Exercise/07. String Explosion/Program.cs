using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int explosion = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explosion = int.Parse(input[i + 1].ToString());
                    i = MakeExplosion(i + 1, input, explosion, i);
                }
            }
            Console.WriteLine(input);
        }

        private static int MakeExplosion(int v, StringBuilder input, int explosion, int i)
        {
            while (explosion != 0 && v < input.Length)
            {
                if (input[v] != '>')
                {
                    input.Remove(v, 1);
                    explosion--;

                }
                else
                {
                    explosion += int.Parse(input[v + 1].ToString());
                    v++;
                    i = v;
                }
            }
            return i;
        }
    }
}
