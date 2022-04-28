using System;
using System.Collections.Generic;

namespace _3.Objects_Classes
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                string action = data[0];
                string name = data[1];
                string duration = data[2];

                Song song = new Song();

                song.TypeList = action;
                song.Name = name;
                song.Duration = duration;

                songs.Add(song);

            }
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song songOne in songs)
                {
                    Console.WriteLine(songOne.Name);
                }
            }
            else
            {
                foreach (Song songOne in songs)
                {
                    if (songOne.TypeList == typeList)
                    {
                        Console.WriteLine(songOne.Name);
                    }
                }
            }

        }
    }
}
