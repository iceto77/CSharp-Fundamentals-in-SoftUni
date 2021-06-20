using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            string inputValue = Console.ReadLine();
            if (inputType == "int")
            {
            Console.WriteLine(DoWhatYouHaveToDo(int.Parse(inputValue)));
            }
            else if (inputType == "real")
            {
                double result = DoWhatYouHaveToDo(double.Parse(inputValue));
                Console.WriteLine($"{result:f2}");
            }
            else
            {
                Console.WriteLine(DoWhatYouHaveToDo(inputValue));
            }
        }

        static int DoWhatYouHaveToDo(int inputNum)
        {
            int result = inputNum * 2;
            return result;
        }
        static double DoWhatYouHaveToDo(double inputNum)
        {
            double result = inputNum * 1.5;
            return result;
        }
        static string DoWhatYouHaveToDo(string inputStr)
        {
            string result = "$" + inputStr + "$";
            return result;
        }
    }
}
