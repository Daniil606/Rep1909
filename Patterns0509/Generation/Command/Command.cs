using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Command
{
    public class Command
    {
        public void Run()
        {
            TextFile sometext = new TextFile();
            sometext.Text = "You listen up the story";
            CopyCommand copyCommand = new CopyCommand();
            PasteCommand pasteCommand = new PasteCommand();
            copyCommand.textFile = sometext;
            pasteCommand.textFile = sometext;
            copyCommand.Execute();
            pasteCommand.Execute();

        }
    }
}
