using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int startIndex = input.LastIndexOf("\\") + 1;
            int lenght = input.IndexOf(".") - startIndex;
            string fileName = input.Substring(startIndex, lenght);
            startIndex = input.IndexOf(".") + 1;
            string fileExtension = input.Substring(startIndex);
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: { fileExtension}");
        }
    }
}
