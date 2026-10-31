using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Command
{
    public class PasteCommand : AbstractCommand
    {
        public override void Execute()
        {
            textFile.buffer = textFile.Text;
            Console.WriteLine($"Pasted: {textFile.buffer}");
        }
    }
}
