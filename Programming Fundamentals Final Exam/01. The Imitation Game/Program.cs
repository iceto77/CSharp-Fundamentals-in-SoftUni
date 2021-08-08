using System;
using System.Linq;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomingMessage = Console.ReadLine();
            StringBuilder decodingMessage = new StringBuilder(incomingMessage);
            incomingMessage = Console.ReadLine();
            while (incomingMessage != "Decode")
            {
                string[] command = incomingMessage.Split("|").ToArray();
                switch (command[0])    
                {
                    case "Move":
                        int moves = int.Parse(command[1]);
                        StringBuilder temText = new StringBuilder();
                        for (int i = 0; i < moves; i++)
                        {
                            temText.Append(decodingMessage[i]);
                        }
                        decodingMessage.Append(temText);
                        temText.Clear();
                        for (int i = moves; i < decodingMessage.Length; i++)
                        {
                            temText.Append(decodingMessage[i]);
                        }
                        decodingMessage.Clear();
                        decodingMessage.Append(temText);
                        break;
                    case "Insert":
                        int index = int.Parse(command[1]);
                        string value = command[2];
                        decodingMessage.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string target = command[1];
                        string newText = command[2];
                        while (decodingMessage.ToString().Contains(target))
                        {
                            decodingMessage.Replace(target, newText);
                        }
                        break;
                }
                incomingMessage = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {decodingMessage}");
        }
    }
}
