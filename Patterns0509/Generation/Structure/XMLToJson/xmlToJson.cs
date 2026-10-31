using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns0509.Generation
{
    public static class xmlToJson
    {
        public static string Convert(string xml)
        {
            var xdoc = XDocument.Parse(xml);
            string json = JsonConvert.SerializeXNode(xdoc, Formatting.Indented);
            return json;
        }
    }
}
