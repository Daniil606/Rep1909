using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Builder
{
    internal class Worker
    {
        public Worker() 
        {
            building = new Building();
        }
        public Building building;
        public Building build() 
        { 
            return building; 
        }

        public Worker Foundation(string foundation)
        { 
            building.Foundation = foundation;
            return this;
        }

        public Worker Walls(string walls)
        {
            building.Walls = walls;
            return this;
        }

        public Worker Roof(string roof)
        {
            building.Roof = roof;
            return this;
        }

        public Worker Interior(string interior)
        {
            building.Interior = interior;
            return this;
        }
    }
}
