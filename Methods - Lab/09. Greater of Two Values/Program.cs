using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (dataType == "int")
            {
                int firstNum = int.Parse(firstValue);
                int secondNum = int.Parse(secondValue);
                Console.WriteLine(GetMax(firstNum, secondNum));
            }
            else if (dataType == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                Console.WriteLine((char)GetMax(firstChar, secondChar));   
            }
            else if (dataType == "string")
            {
               Console.WriteLine(GetMax(firstValue, secondValue));
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue > secondValue)
            {
                return firstValue;
            }
            return secondValue;
        }
        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) == 1 )
            {
                return firstValue;
            }
            return secondValue;
        }
    }
}
