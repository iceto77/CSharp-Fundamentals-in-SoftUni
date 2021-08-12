using System;
using System.Linq;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder myPassword = new StringBuilder(input);
            input = Console.ReadLine();
            while (input != "Done")
            {
                string[] command = input.Split().ToArray();
                StringBuilder newPass = new StringBuilder();
                switch (command[0])
                {
                    case "TakeOdd":
                        string temp = myPassword.ToString();
                        newPass.Clear();
                        for (int i = 1; i < temp.Length; i += 2)
                        {
                            newPass.Append((char)temp[i]);
                        }
                        myPassword = newPass;
                        Console.WriteLine(myPassword.ToString());
                        break;
                    case "Cut":
                        int index = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        temp = myPassword.ToString();
                        string targetSubstring = temp.Substring(index, length);
                        int startIndex = temp.IndexOf(targetSubstring);
                        newPass.Clear();
                        for (int i = 0; i < startIndex; i++)
                        {
                            newPass.Append((char)temp[i]);
                        }
                        for (int i = startIndex + length; i < temp.Length; i++)
                        {
                            newPass.Append((char)temp[i]);
                        }
                        myPassword = newPass;
                        Console.WriteLine(myPassword.ToString());
                        break;
                    case "Substitute":
                        temp = myPassword.ToString();
                        if (temp.Contains(command[1]))
                        {
                            myPassword.Replace(command[1], command[2]);
                            Console.WriteLine(myPassword.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {myPassword.ToString()}");
        }
    }
}
