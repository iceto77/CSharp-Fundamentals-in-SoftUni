using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string target = Console.ReadLine().ToLower();
            string inputText = Console.ReadLine();
            int targetIndex = inputText.IndexOf(target);
            while (targetIndex >= 0)
            {
                inputText = inputText.Remove(targetIndex, target.Length);
                targetIndex = inputText.IndexOf(target);
            }
            Console.WriteLine(inputText);
        }
    }
}
