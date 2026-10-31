using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Behavior
{
    public class CarService
    {
        public CarDAO carDAO;
        public void SafeCar(Car car, int UserId)
        { 
            List<Car> cars = carDAO.Cars(UserId);
            if (cars.Contains(car))
            {
                carDAO.UpdateCar(car, UserId);
            }
            else
            { 
                carDAO.AddCar(car, UserId);
            }
        }

        public CarService(CarDAO carDAO)
        {
            this.carDAO = carDAO;
        }
    }
}
