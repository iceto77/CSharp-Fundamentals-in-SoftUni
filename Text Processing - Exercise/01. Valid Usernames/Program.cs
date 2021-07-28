using System;
using System.Linq;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] users = input.Split(", ").ToArray();
            for (int i = 0; i < users.Length; i++)
            {
                string curentUser = users[i];
                if (curentUser.Length >= 3 && curentUser.Length <= 16)
                {
                    if (IsContainsLettersNumbersHyphensUnderscores(curentUser))
                    {
                        Console.WriteLine(curentUser);
                    }
                }
            }

        }

        private static bool IsContainsLettersNumbersHyphensUnderscores(string user)
        {
            bool IsValidUser = true;
            for (int i = 0; i < user.Length; i++)
            {
                IsValidUser = Char.IsLetterOrDigit(user[i]);
                if (user[i] == '-' || user[i] == '_')
                {
                    IsValidUser = true;
                }
                if (!IsValidUser)
                {
                    return false;
                }
            }
            return IsValidUser;
        }
    }
}

