using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    /// <summary>
    ///  This class holds persons objects and gives a few metods...
    /// </summary>
    class Persons
    {
        /// <summary>
        /// Persons collection stores person objects
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Adds a person to collection
        /// </summary>
        /// <param name="person">Added person</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        /// Returns a person to caller application
        /// </summary>
        /// <param name="index">Person index in collection</param>
        /// <returns>Returned person object</returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string sosialSecurityNumber)
        {
            foreach(Person person in persons)
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
        { foreach 
                (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
                }
    }
}
