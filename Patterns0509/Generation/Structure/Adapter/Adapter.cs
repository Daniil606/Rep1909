using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    public static class Adapter
    {
        public static void Run()
        { 
            string jsonS = "{\"name\": \"Alice\", \"age\": 28, \"isHuman\": true}";
            jsonLogger.print(jsonS);
        }
    }
}
