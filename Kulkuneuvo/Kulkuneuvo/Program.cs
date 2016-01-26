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

            Engine engine1 = new Engine { Name = "Nissan", Type = "Bensiin", Size = "1.5L" };



            Vehicle car1 = new Vehicle { Name = "Datsun", Model = "100A" };

            car1.AddEngine(engine1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre3);
            car1.AddTyre(tyre3);

            Console.WriteLine(car1.ToString());
            Console.WriteLine("Press erter");
            Console.ReadLine();


        }
    }
}
