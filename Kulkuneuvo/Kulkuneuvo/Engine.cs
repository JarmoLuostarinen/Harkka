﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulkuneuvo
{
    class Engine
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public override string ToString()
        {



            return "Name" + Name + " Type" + Type + "Size" + Size;
        }
    }
}
