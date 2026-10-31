using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Behavior
{
    internal class CarController
    {
        CarService carService = new CarService(new CarDAO());
        int[] grantedUserId = new int[4] { 1, 2 , 3 , 4};
        public void SafeCar(Car car, int UserId)
        { 
            foreach (int i in grantedUserId) 
            {
                carService.SafeCar(car, UserId);
            }
        }
    }
}
