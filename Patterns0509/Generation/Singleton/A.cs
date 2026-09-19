using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    internal class A
    {
        ILogger log;
        public A()
        {
            log = Logger.GetInstance();
            log.Log("Class A has inited.");

            Console.WriteLine(log.GetHashCode());
        }
    }
}
