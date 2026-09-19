using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.FactoryMethod
{
    internal class ComputerMethod
    {
        public static IComputer CreateNewComputer()
        {
            return new NewComputer();
        }

        public static IComputer CreateOldComputer()
        {
            return new OldComputer();
        }
    }
}
