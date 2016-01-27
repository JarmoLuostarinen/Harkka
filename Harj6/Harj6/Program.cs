

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object from Person
            Persons myFriends = new Persons();

            // create a Friend

            Person person1 = new Person { Firstname = "Jussi", Lastname = "Pietilä", SosialSecurityNumber = "251284-AA1"};
            Person person2 = new Person { Firstname = "Matti", Lastname = "Puttonen", SosialSecurityNumber = "250665-BA1" };
            Person person3 = new Person { Firstname = "Juuso", Lastname = "Joku", SosialSecurityNumber = "251290-AAA" };

            //add person to Persons

            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection

            myFriends.PrintCollection();

            // Get one person

            Console.WriteLine("Get one person");
            Person person4 = myFriends.GetPerson(1);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person from that position");
            }

            // Find person whit sotu
            string sosialSecurityNumber = "251290-AAA";
            Console.WriteLine("Find person whit sotu: " + sosialSecurityNumber);
            Person person5 = myFriends.FindPerson(sosialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found...");
            }

        }
    }
}
