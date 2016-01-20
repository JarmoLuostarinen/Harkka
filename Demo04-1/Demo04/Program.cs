using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 300;
            Console.WriteLine("Car speed is: " + car.Speed);
            Console.ReadLine();
        }
    }
}
