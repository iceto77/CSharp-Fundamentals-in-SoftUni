using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char charA = char.Parse(Console.ReadLine());
            char charB = char.Parse(Console.ReadLine());
            CharactersInBetween(charA, charB);
        }

        static void CharactersInBetween(char charA, char charB)
        {
            if (charB < charA)
            {
                char midleC = charA;
                charA = charB;
                charB = midleC;
            }
            for (char i = charA; i < charB - 1; i++)
            {
                Console.Write($"{(char)(i+1)} ");
            }
        }
    }
}