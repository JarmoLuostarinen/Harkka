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
            Tyre tyre1 = new Tyre { Name = "Nokia", Type = "Nasta", Size = "185R14" };
            Tyre tyre2 = new Tyre { Name = "GoodYear", Type = "Summer", Size = "225R17" };
            Tyre tyre3 = new Tyre { Name = "YokoHama", Type = "Kitka", Size = "185R13" };



            Vehicle car = new Vehicle { Name = "Datsun", Engine = " Nissan", Model = "100A" };

            car.AddTyre(tyre1);
            car.AddTyre(tyre1);
            car.AddTyre(tyre3);
            car.AddTyre(tyre3);

            Console.WriteLine(car.ToString());
            Console.WriteLine("Press erter");
            Console.ReadLine();


        }
    }
}
