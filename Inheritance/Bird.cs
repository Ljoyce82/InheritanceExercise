using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool canFly { get; set; }
        public bool hasfeathers { get; set; }
        public bool canSwim { get; set; }
        public string species { get; set; }

    }
}
