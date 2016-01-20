using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student : Person
    {
        public Student()
        {

        }
        public Student(string firstName, string lastName)
            :base(firstName,lastName)
        {
           
        }
        public void StudentMethod()
        {
            Console.WriteLine("Student does something... ");
        }
        public override string ToString()
        {
            return base.ToString();
           
        }
    }
}
