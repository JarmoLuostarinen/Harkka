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
        public string Engine { get; set; }
        public List<Tyre> Tyres { get; }

        public Vehicle()
        {

            Tyres = new List<Tyre>();
        }
        
        public void AddTyre(Tyre tyre)
        {
            Tyres.Add(tyre);
        }
        public void AddEngine(Engine engine)
        {
            Engine.Add(engine);
        }
        public override string ToString()
        {
            
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + "Engine : "+Engines + " Tyres: \n";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n";
                sVehicle += Engines.ToString();

            }
            return sVehicle;
        }


    }
}
