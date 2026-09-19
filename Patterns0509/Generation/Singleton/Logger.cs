
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    internal class Logger : ILogger
    {
        public static readonly Logger Instance = new Logger();
        private Logger() { }
        public void Log(string message) 
        {
            Console.WriteLine(message);
        }
        public static Logger GetInstance()
        { 
            return Instance;
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
