using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.Behavior
{
    internal class ChainOfResponsibility
    {
        CarController carController;
        public static void Run()
        { 
            CarController carController = new CarController();

            Car car1 = new Car() { Id = 1, Color = "red", Name = "Skoda"};
            Car car2 = new Car() { Id = 2, Color = "blue", Name = "VV" };
            Car car3 = new Car() { Id = 3, Color = "black", Name = "BMW" };
            Car car4 = new Car() { Id = 4, Color = "white", Name = "MB" };
            Car car5 = new Car() { Id = 5, Color = "green", Name = "Lada" };

            foreach (var x in new Car[5] { car1, car2, car3,car4,car5} )
            {
                carController.SafeCar(x,x.Id);
            }
        }
    }
}
