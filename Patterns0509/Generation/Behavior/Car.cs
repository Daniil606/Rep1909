using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Behavior
{
    public class Car
    {
        public int Id;
        public string Name;
        public string Color;
        public override bool Equals(object obj)
        { 
            return ((Car)obj).Id.Equals(this.Id);
        }
    }
}
