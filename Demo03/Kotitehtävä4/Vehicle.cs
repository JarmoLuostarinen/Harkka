using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä4
{
    class Vehicle
    {
        // properties

        public string Name { get; set; }

        public int Tyres { get; set; }

        public int Speed { get; set; }

        //method display Vehicle data

        public void PrintData()
        {
            Console.WriteLine("Vehicle data:");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- tyres : " + Tyres);
            Console.WriteLine("- Speed :" + Speed);

        }
        public override string ToString()
        {
            return "Name " + Name + "tyres" + Tyres + "Speed" + Speed;
        }
    }
}
