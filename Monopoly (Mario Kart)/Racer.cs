using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly__Mario_Kart_
{
    class Racer
    {
            public readonly string name;
            public readonly string super_star;
            public readonly string power_up;

            public Racer(string name, string super_star, string powerup)
            {
                this.name = name;
                this.super_star = super_star;
                this.power_up = powerup;
            }
    }
}
