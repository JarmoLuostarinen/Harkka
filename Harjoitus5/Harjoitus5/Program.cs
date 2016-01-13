/*
Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.

Esimerkkitoiminta:


    Anna sekunnit > 3661 [Enter]
    Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekuntti
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            
            Console.WriteLine("sekunnit ");
            luku = int.Parse(Console.ReadLine());
            int luku1 = luku / 3600;
            int luku2 = (luku -luku1*3600)/60;
            int luku3 =  (luku-luku1*3600 - luku2*60);
            Console.WriteLine("tunnit");
            Console.WriteLine(luku1);
            Console.WriteLine("Minuutit");
            Console.WriteLine(luku2);
            Console.WriteLine("Sekunnit");
            Console.WriteLine(luku3);

            Console.ReadLine();
        }
    }
}
