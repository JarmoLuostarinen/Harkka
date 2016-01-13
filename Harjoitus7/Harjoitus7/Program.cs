/*
Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.

Algoritmi
4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
           
            Console.Write("vuosi > ");
            vuosi = int.Parse(Console.ReadLine());
            Console.WriteLine("Annoit vuoden " , vuosi);

            if (vuosi % 4 == 0 && vuosi % 100 != 0 || vuosi % 400 == 0)
            {
                Console.WriteLine("Karkausvuosi");

            }
            else
                Console.WriteLine("Ei ole karkausvuosi");

            Console.ReadLine();
        }
    }
}
