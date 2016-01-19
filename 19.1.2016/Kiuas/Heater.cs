using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    class Heater
    {
        //properties
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        //method prints heater data
      
            public void PrintData()
        {
            Console.WriteLine("Heater:");
            Console.WriteLine(" - Temperature : {0} Humindity {1} Is on {2}", Temperature,Humidity,IsOn);
            }

        //method returns heater data

        public override string ToString()
        {
           // return base.ToString();
            return "Temperature :" + Temperature + "Humidity :" + Humidity;

            Console.ReadLine();
        }
    }
}
