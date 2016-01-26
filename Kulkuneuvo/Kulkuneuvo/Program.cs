using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulkuneuvo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre = new Tyre { Name = "Nokia", Type = "Nasta", Size = "185R14" };
        

        
            Vehicle car = new Vehicle { Name = "Datsun", Engine = " Nissan", Model = "100A" };

            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);

            Console.WriteLine(car.ToString());
            Console.WriteLine("Press erter");
            Console.ReadLine();


        }
    }
}
