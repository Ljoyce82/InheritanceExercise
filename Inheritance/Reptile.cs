using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int hasLegs {  get; set; }
        public bool hasTail { get; set; }
        public bool isVenomous { get; set; }
        public bool canClimb { get; set; }
    }
}
