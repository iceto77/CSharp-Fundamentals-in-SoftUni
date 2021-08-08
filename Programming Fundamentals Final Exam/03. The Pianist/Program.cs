using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }
        public string Composer { get; set; }
        public string Key { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int songNum = int.Parse(Console.ReadLine());
            SortedDictionary<string, Piece> piecesData = new SortedDictionary<string, Piece>();
            string input = string.Empty;
            for (int i = 0; i < songNum; i++)
            {
                input = Console.ReadLine();
                string[] currentPiece = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                piecesData.Add(currentPiece[0], new Piece(currentPiece[1], currentPiece[2]));
            }
            input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] command = input.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "Add":
                        if (!piecesData.ContainsKey(command[1]))
                        {
                            piecesData.Add(command[1], new Piece(command[2], command[3]));
                            Console.WriteLine($"{command[1]} by {command[2]} in {command[3]} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        if (piecesData.ContainsKey(command[1]))
                        {
                            piecesData.Remove(command[1]);
                            Console.WriteLine($"Successfully removed {command[1]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        }
                            break;
                    case "ChangeKey":
                        if (piecesData.ContainsKey(command[1]))
                        {
                            piecesData[command[1]].Key = command[2];
                            Console.WriteLine($"Changed the key of {command[1]} to {command[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {command[1]} does not exist in the collection.");
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var item in piecesData.OrderBy(x => x.Key).ThenBy(x => x.Value.Composer))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
}
