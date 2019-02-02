using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineRadioDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Song> playlist = new List<Song>();
            int[] totalTime = new int[3];

            for (int i = 0; i < count; i++)
            {
                string[] songInfo = Console.ReadLine()
                    .Split(';');

                if(songInfo.Length!=3)
                {
                    Console.WriteLine($"Invalid Song.");
                    continue;
                }

                string artistName = songInfo[0];
                string songName = songInfo[1];
                int[] songLength = new int[2];

                try
                {
                    songLength = songInfo[2]
                        .Split(':', StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid song length.");
                    continue;
                }

                try
                {
                    Song newSong = new Song(artistName, songName, songLength);
                    playlist.Add(newSong);
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            int totalDuration = 0;
            foreach (var song in playlist)
            { totalDuration += song.SongLength[0] * 60 + song.SongLength[1]; }
            int minutes = totalDuration / 60;
            int seconds = totalDuration % 60;
            int hours = minutes / 60;
            minutes %= 60;

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
