using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Builder
{
    internal class Building
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Interior { get; set; }

        public override string ToString()
        {
            return "Building: " + Foundation + " " + Walls + " " + Roof + " " + Interior; 
        }

    }
}
