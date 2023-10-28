using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    internal abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
    }
}
