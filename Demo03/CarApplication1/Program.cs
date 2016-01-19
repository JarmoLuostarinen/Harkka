using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one car instance

            Car car = new Car();

            car.Model = "Audi";
            car.Speed = 180;
            car.Color = "White";
            car.Engine = 2.0;
            car.FuzzyDices = false;

            car.PrintData();



            Car nascar = new Car("Chervolet");

           // Console.WriteLine("FuzzyDices = " + car.FuzzyDices);
           // Console.WriteLine("Model = " + nascar.Model);
            nascar.Speed = 200;
            nascar.Color = "Red";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            
            nascar.PrintData();
            nascar.Accelrate(50);
            nascar.PrintData();

            Console.ReadLine();
        }
    }
}
