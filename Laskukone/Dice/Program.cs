using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1

{
    class Program
    {
        static void Main(string[] args)
        {
            Dices dice = new Dices();
            Console.WriteLine("How many throws do you want to throw?: ");
            string times = Console.ReadLine();
            int number;
            bool result = int.TryParse(times, out number);
            // luodaan olio Noppa-Luokasta
            for (int i=1;i<= number; i++)
            {
                int luku = dice.Throw(); //1-6
                Console.WriteLine("Luku on {0}", luku);
            }

        }
    }
}
