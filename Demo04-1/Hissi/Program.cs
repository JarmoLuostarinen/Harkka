using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Program
    {
        static void Main(string[] args)
        {

            Floors floor = new Floors();
            int nro = 0;
            do
            {

                Console.WriteLine("Elevator floor?(1-5) 0 stops the elevator ");
                string line = Console.ReadLine();
                nro = int.Parse(line);
                floor.Floor = nro;
                Console.WriteLine("Elevator is now at floor " + floor.Floor);

            } while (nro != 0);
                
            
        }
    }
}
