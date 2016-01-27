using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        /// <summary>
        /// CD collection stores song objects
        /// </summary>
        public List<Song> songs;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public CD()
        {
           songs = new List<Song>();
        }

        /// <summary>
        /// Adds a song to collection
        /// </summary>
        /// <param name="song">Added song</param>
        public void AddSong(CD song)
        {
            songs.Add(song);
        }
        /// <summary>
        /// Returns a song to caller application
        /// </summary>
        /// <param name="index">song index in collection</param>
        /// <returns>Returned song object</returns>
        public Song GetSong(int index)
        {
            if (index < songs.Count) return songs.ElementAt(index);
            else return null;
        }

        public Song FindSong(string Name)
        {
            foreach (Song song in songs)
            {
                if (Name.Equals(song.SongName))
                {
                    return song;
                }
            }
            // person with sotu not found...
            return null;
        }

        public void PrintCollection()
        {
            foreach
                  (Song songs in songs)
            {
                Console.WriteLine(songs.ToString());
            }
        }
    }
}
