using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int openingBracket = 0;
            int closingBracket = 0;
            bool isBracket = false;
            bool isBalanced = true;
            for (int i = 0; i < n; i++)
            {
                string inputText = Console.ReadLine();
                if (inputText == "(")
                {
                    openingBracket++;
                    if (isBracket == true)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        isBracket = true;
                        isBalanced = false;
                    }
                    
                }
                if (inputText == ")")
                {
                    closingBracket++;
                    if (isBracket == false)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        isBracket = false;
                        isBalanced = true;
                    }
                }

            }
            if (openingBracket == closingBracket && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
