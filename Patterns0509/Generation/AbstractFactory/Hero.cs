using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation.AbstractFactory
{
    internal class Hero
    {
        IHit hit;
        IMove move;
        public string Name { get; }

        public Hero(IHit hit, IMove move, string Name)
        {
            this.hit = hit;
            this.move = move;
            this.Name = Name;
        }

        public void Hit()
        {
            Console.Write($"I'm {Name}. "); hit.Hit();
        }

        public void Move()
        {
            Console.Write($"I'm {Name}. "); move.Move();
        }
    }
}
