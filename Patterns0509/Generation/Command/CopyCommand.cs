using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Command
{
    internal class CopyCommand : AbstractCommand
    {   
        public override void Execute()
        {
            textFile.buffer = textFile.Text;
            Console.WriteLine($"Copyed: {textFile.buffer}");
        }

    }
}
