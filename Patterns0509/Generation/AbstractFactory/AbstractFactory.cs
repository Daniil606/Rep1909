using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.AbstractFactory
{
    internal class AbstractFactory
    {
        public static void Run()
        { 
            Hero pudge = HeroFactory.CreatePudge();
            Hero viper = HeroFactory.CreateViper();
            Hero ranger = HeroFactory.CreateRanger();
            Hero swimmer = HeroFactory.CreateSwimmer();

            pudge.Move();
            pudge.Hit();

            viper.Move();
            viper.Hit();

            ranger.Move();
            ranger.Hit();

            swimmer.Move();
            swimmer.Hit();
        }
    }
}
