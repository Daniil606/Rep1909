using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Behavior
{
    public class CarDAO
    {
        Dictionary<int,List<Car>> CarDict = new Dictionary<int,List<Car>>();
        public void AddCar(Car car, int UserId)
        {
            if (CarDict.ContainsKey(UserId))
            { 
                CarDict[UserId].Add(car); 
            }
            else
            {
                CarDict.Add(UserId, new List<Car>());
                CarDict[UserId].Add(car);
            }
        }

        public void UpdateCar(Car car, int UserId)
        {
            if (CarDict.ContainsKey(UserId))
            {
                Car carin = CarDict[UserId].Where(x => x.Id == car.Id).First();
                carin.Name = car.Name;
                carin.Color = car.Color;
            }
        }

        public List<Car> Cars(int UserId)
        {
            if (!CarDict.ContainsKey(UserId))
            {
                CarDict.Add(UserId, new List<Car>());
                return CarDict[UserId];
            }
            else return CarDict[UserId];
        }
    }
}
