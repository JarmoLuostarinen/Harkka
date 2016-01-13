/*
Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.

Esimerkkitoiminta:


    Anna matka > 250 [Enter]
    Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double kulutus = 0.0702;
            double hinta = 1.595;
            
            Console.Write("Matka  ");
            matka = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Hinta on {0:F2} euroa" ,(matka*kulutus)* hinta);
            // voidaan kirjoittaa myös
            Console.WriteLine("Kulutus {0:F2}", kulutus*matka);

            Console.ReadLine();
        }
    }
}
