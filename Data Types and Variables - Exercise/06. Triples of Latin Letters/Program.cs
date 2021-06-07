using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + inputNumber; i++)
            {
                for (char j = 'a'; j < 'a' + inputNumber; j++)
                {
                    for (char k = 'a'; k < 'a' + inputNumber; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
            //Първи вариант
            //for (int i = 97; i < 97 + inputNumber; i++)
            //{
            //    for (int j = 97; j < 97 + inputNumber; j++)
            //    {
            //        for (int k = 97; k < 97 + inputNumber; k++)
            //        {
            //            Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
            //        }
            //    }
            //}
        }
    }
}
