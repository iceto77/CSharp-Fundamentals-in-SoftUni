using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool isInteger = int.TryParse(input, out int integerType);
                bool isFloating = float.TryParse(input, out float floatType) ;
                bool isCharacters = char.TryParse(input, out char charType);
                bool isBoolean = bool.TryParse(input, out bool boolType);
                //bool isStrings = false;
                if (isInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isFloating)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isCharacters)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
