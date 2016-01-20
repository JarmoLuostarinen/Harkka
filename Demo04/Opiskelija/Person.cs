using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phonenumber { get; set; }

        public Person()
        { }

        public Person(string firstName, string lastName)
        {
            Firstname = firstName;
            Lastname = lastName;
        }
        public void PersonMethod()
        {
            Console.WriteLine("Person does something...");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Address + " " + Age + " " + Phonenumber;

        }
    }
}
