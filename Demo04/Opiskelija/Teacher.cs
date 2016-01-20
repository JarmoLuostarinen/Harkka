using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }
        public Teacher(string firstName, string lastName, string room)
            :base(firstName,lastName)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("Teacher does something... ");
        }
        public override string ToString()
        {
            
            
                return base.ToString() + " " + Room;
            
        }
    }
}
