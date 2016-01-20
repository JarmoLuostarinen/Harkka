using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Kirsi";
            person.Lastname = "Kernel";
            person.Age = 35;
            person.Address = "Piippukatu 2";
            person.Phonenumber = "02001215";

            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi", "Konsoli", "D456");
            teacher.Address = "Piippukatu1";
            teacher.Age = 40;
            teacher.Phonenumber = "010-541256";

            Console.WriteLine(teacher.ToString());

            Student student = new Student("Juuso", "Jokio");
            teacher.Address = "Piippukatu 66";
            teacher.Age = 21;
            teacher.Phonenumber = "020-541256";

            Console.WriteLine(student.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
