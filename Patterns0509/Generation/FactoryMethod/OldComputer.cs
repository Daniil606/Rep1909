using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.FactoryMethod
{
    internal class OldComputer : IComputer
    {
        public void Run()
        {
            Console.WriteLine("Win7 started");
        }
        public void Stop()
        {
            Console.WriteLine("Win7 stoped");
        }
    }
}
