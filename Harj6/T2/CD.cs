using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
        /// <summary>
        /// CD collection stores song objects
        /// </summary>
        public List<Song> cD;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public CD()
        {
            cD = new List<CD>();
        }

        /// <summary>
        /// Adds a song to collection
        /// </summary>
        /// <param name="song">Added song</param>
        public void AddPerson(CD cD)
        {
            cD.Add(cD);
        }
        /// <summary>
        /// Returns a song to caller application
        /// </summary>
        /// <param name="index">song index in collection</param>
        /// <returns>Returned song object</returns>
        public song GetSong(int index)
        {
            if (index < song.Count) return cD.ElementAt(index);
            else return null;
        }

        public song FindPerson(string sosialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                if (sosialSecurityNumber.Equals(person.SosialSecurityNumber))
                {
                    return person;
                }
            }
            // person with sotu not found...
            return null;
        }

        public void PrintCollection()
        {
            foreach
                  (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
