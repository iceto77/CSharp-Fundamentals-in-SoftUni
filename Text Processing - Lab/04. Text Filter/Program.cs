using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string inputText = Console.ReadLine();
            foreach (var item in specialWords)
            {
                inputText = inputText.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(inputText);
        }
    }
}
