using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    abstract class DrawinObject
    {
        public string Name { get; set; }
        public abstract void Draw();
    }
}
