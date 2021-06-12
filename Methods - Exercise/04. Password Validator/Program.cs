using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool isValidPassword = false;
            bool isValidLength = CheckLength(inputPassword);
            bool isLettersAndDigits = CheckForLettersAndDigits(inputPassword);
            bool isTwoDigits = CheckForTwoDigits(inputPassword);
            isValidPassword = isValidLength && isLettersAndDigits && isTwoDigits;
            if (isValidPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckForTwoDigits(string inputPassword)
        {
            int count = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (inputPassword[i] >=48 && inputPassword[i] <= 57)
                {
                    count++;
                }
                if (count == 2)
                {
                    return true;
                }
            }
            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }

        static bool CheckForLettersAndDigits(string inputPassword)
        {           
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (inputPassword[i] < 48 || (inputPassword[i] > 57 && inputPassword[i] < 65) || (inputPassword[i] > 90 && inputPassword[i] < 97) || inputPassword[i] > 122)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;                    
                }
            }
            return true;
        }

        static bool CheckLength(string inputPassword)
        {
            if (inputPassword.Length >=6 && inputPassword.Length <= 10)
            {
                return true;
            }
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
    }
}
