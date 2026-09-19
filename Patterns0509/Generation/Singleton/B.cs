using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    internal class B
    {
        ILogger log;
        public B()
        {
            log = Logger.GetInstance();
            log.Log("Class B has inited.");

            Console.WriteLine(log.GetHashCode());
        }
    }
}
