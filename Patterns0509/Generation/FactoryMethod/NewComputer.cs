using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.FactoryMethod
{
    internal class NewComputer : IComputer
    {
        public void Run()
        {
            Console.WriteLine("Win11 started");
        }
        public void Stop()
        {
            Console.WriteLine("Win11 stoped");
        }
    }
}
