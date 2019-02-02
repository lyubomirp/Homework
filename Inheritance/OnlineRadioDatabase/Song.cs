using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRadioDatabase
{
    class Song
    {
        private const int MAX_MINUTES = 14;
        private const int MAX_SECONDS = 59;
        private const int MAX_LENGTH = 899;


        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    InvalidInput("Song name should be between 3 and 30 symbols.");
                }
                name = value;
            }
        }


        private string artistName;

        public string ArtistName
        {
            get { return artistName; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    InvalidInput("Artist name should be between 3 and 20 symbols.");
                }
                artistName = value;
            }
        }


        private int[] songLength;

        public int[] SongLength
        {
            get { return songLength; }
            set
            {
                CheckOverallTime(value);
                songLength = value;
            }
        }


        public Song(string artistName, string name,int[] songLength)
        {

            
            this.ArtistName = artistName;
            this.Name = name;
            this.SongLength = songLength;

        }


        //METHODS

        private void InvalidInput(string v)
        {
            throw new ArgumentException(v);
        }


        private void CheckOverallTime(int[] value)
        {
            int minutes = value[0];
            int seconds = value[1];

            if (minutes > MAX_MINUTES || minutes < 0)
            {
                InvalidInput("Song minutes should be between 0 and 14.");
            }

            if (seconds > MAX_SECONDS || seconds < 0)
            {
                InvalidInput("Song seconds should be between 0 and 59.");
            }
        }

    }
}
