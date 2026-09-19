using Patterns0509.Generation.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.FactoryMethod
{
    internal class FactoryMethod
    {
        public static void Run()
        { 
            IComputer comp1 = ComputerMethod.CreateOldComputer();
            IComputer comp2 = ComputerMethod.CreateNewComputer();

            comp1.Run();
            comp2.Run();

            comp1.Stop();
            comp2.Stop();
        }
    }
}
