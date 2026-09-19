using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Builder
{
    internal class Builder
    {
        public void Run()
        {
            Building building = new Worker().Foundation("Foundation1")
                .Walls("Walls1")
                .Roof("Roof1")
                .Interior("Interior1")
                .build();     
        }
    }
}
