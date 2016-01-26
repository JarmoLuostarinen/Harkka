using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulkuneuvo
{
    class Vehicle : Tyre
    {
        
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Engine> Engine { get; }
        public List<Tyre> Tyres { get; }

        public Vehicle()
        {
            Engine = new List<Engine>();
            Tyres = new List<Tyre>();
        }
        public void AddEngine(Engine engine)
        {
            Engine.Add(engine);
        }
        public void AddTyre(Tyre tyre)
        {
            Tyres.Add(tyre);
        }
        public override string ToString()
        {
            
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + "Engine : "+(Engine in Engine) + " Tyres: \n";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n";

            }
            return sVehicle;
        }


    }
}
