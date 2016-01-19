using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one car instance

            Vehicle vehicle = new Vehicle();

            vehicle.Name = "Audi";
            vehicle.Speed = 180;
            vehicle.Tyres = 205;
            vehicle.PrintData();
            Console.WriteLine(vehicle.ToString());

            Console.ReadLine();
          
           

          
        }
    }
}
