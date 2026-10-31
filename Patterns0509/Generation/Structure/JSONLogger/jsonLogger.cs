using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Patterns0509.Generation
{
    public class jsonLogger
    {
        public static void print(string jsonLine) 
        {
            var json = JsonDocument.Parse(jsonLine);
            foreach (var property in json.RootElement.EnumerateObject())
            { 
                Console.WriteLine($"{property.Name}: {property.Value}");
            }
        }
    }
}
