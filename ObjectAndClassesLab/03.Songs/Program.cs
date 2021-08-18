using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string playlist = string.Empty;
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().
                    Split("_", StringSplitOptions.RemoveEmptyEntries).
                    ToList();
                Song song = new Song();
                song.TypeList = input[0];
                song.Name = input[1];
                song.time = input[2];

                songs.Add(song);
                if(i==n-1)
                {
                    playlist = Console.ReadLine();
                }

            }
             if(playlist=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
             else
            {
                foreach  (Song song in songs)
                {
                    if(song.TypeList==playlist)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

                

            

        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string time { get; set; }
    }
}
