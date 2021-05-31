using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int tryCount = 0;
            string inputPass = Console.ReadLine();
            string pass = "";
            for (int i = userName.Length; i > 0; i--)
            {
                pass = pass + userName[i - 1];
            }
            while (pass != inputPass)
            {
                tryCount++;
                if (tryCount == 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPass = Console.ReadLine();
            }
            if (tryCount != 4)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
            else
            {
                Console.WriteLine($"User {userName} blocked!");
            }
        }
    }
}
