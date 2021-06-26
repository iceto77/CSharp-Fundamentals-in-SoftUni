using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> SongData = new List<Song>();
            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> inputData = Console.ReadLine().Split("_").ToList();
                Song curentSong = new Song(inputData[0], inputData[1], inputData[2]);
                SongData.Add(curentSong);
            }
            string finalCommand = Console.ReadLine();
            for (int i = 0; i < SongData.Count; i++)
            {
                if (finalCommand == "all")
                {
                    Console.WriteLine(SongData[i].Name);
                }
                else if (finalCommand == SongData[i].TypeList)
                {
                    Console.WriteLine(SongData[i].Name);
                }
            }

        }
    }
}
