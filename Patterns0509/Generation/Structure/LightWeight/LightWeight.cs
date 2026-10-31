using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    public static class LightWeight
    {

        public class MVD
        { 
            HashSet<string> citizenshipSet = new HashSet<string>();
            public string GetCitizenship(string name)
            {
                if (citizenshipSet.Contains(name)) return name;
                return "-";
            }

            public void AddCShip(string name)
            { 
                citizenshipSet.Add(name);
            }
        }
    }
}
