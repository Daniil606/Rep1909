using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.AbstractFactory
{
    internal class Fly : IMove
    {
        public void Move()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
