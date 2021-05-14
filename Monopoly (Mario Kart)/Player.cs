using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly__Mario_Kart_
{
    class Player
    {
            public readonly Racer racer;
            public List<Property> properties;
            public int boardposition;
            public List<Race> races;
            public int coins;
            public bool jail;
            public readonly int id;
            public readonly bool PC;
            public Player(Racer racer, int id, bool PC)
            {
                this.racer = racer;
                this.boardposition = 0;
                this.races = new List<Race>();
                this.coins = 10;
                this.id = id;
                this.jail = false;
                this.properties = new List<Property>();
                this.PC = PC;
            }

    }
}
