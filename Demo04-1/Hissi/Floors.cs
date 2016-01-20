using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Floors
    {
        //max floor
        private readonly int maxFloor = 5;
        private readonly int minFloor = 1;
        private int floor;
        //property
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value <= maxFloor || value >= minFloor) floor = value;

                else
                {
                    if (value < maxFloor)
                    {
                        Console.WriteLine("Too high - only five floors!");
                        floor = maxFloor;
                    }

                    else
                    {
                        Console.WriteLine("Too low - Going to hell?");
                        floor = maxFloor;
                    }
                }
            }
        }

    }
}
}
