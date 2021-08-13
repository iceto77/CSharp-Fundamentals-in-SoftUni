using System;
using System.Linq;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder rawActivationKey = new StringBuilder(input);
            input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] command = input.Split(">>>").ToArray();
                switch (command[0])
                {
                    case "Contains":
                        string substring = command[1];
                        if (rawActivationKey.ToString().Contains(substring))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        bool IsUpper = (command[1] == "Upper");
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            if (IsUpper)
                            {
                                if (rawActivationKey[i] > 96 && rawActivationKey[i] < 123)
                                {
                                    char newChar = (char)(rawActivationKey[i] - 32);
                                    rawActivationKey[i] = newChar;
                                }
                            }
                            else
                            {
                                if (rawActivationKey[i] > 64 && rawActivationKey[i] < 91)
                                {
                                    char newChar = (char)(rawActivationKey[i] + 32);
                                    rawActivationKey[i] = newChar;
                                }
                            }
                        }
                        Console.WriteLine(rawActivationKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(command[1]);
                        int lenght = int.Parse(command[2]) - startIndex;
                        rawActivationKey.Remove(startIndex, lenght);
                        Console.WriteLine(rawActivationKey);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
