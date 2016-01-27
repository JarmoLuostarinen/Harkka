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
            Engine engine2 = new Engine { Name = "Ford", Type = "Diesel", Size = "2.0L" };



            Vehicle car1 = new Vehicle { Name = "Datsun", Model = "100A" };
            Vehicle car2 = new Vehicle { Name = "Ford", Model = "Mondeo" };

            car1.AddEngine = (engine1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre1);
            car1.AddTyre(tyre3);
            car1.AddTyre(tyre3);

            car2.AddEngine = (engine2);
            car2.AddTyre(tyre2);
            car2.AddTyre(tyre2);
            car2.AddTyre(tyre2);
            car2.AddTyre(tyre2);
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine("Press enter");
            Console.ReadLine();


        }

        private static Engine GetEngine1(Engine engine1)
        {
            return engine1;
        }
    }
}
