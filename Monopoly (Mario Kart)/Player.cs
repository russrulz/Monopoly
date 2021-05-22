﻿using System;
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
            public bool skippower;
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
            this.skippower = false;
            }

        public override string ToString() {
            string str = "";
            str = str + "Racer: " + racer.name + "; ";
            str = str + "Races Won : ";
            foreach (Race r in races) {
                str = str + r.name + ",";
            }
            str =str + "; ";
            str = str + "Property owned :";
            foreach(Property p in properties)
            {
                str = str + p.name + ",";
            }
            str = str + "; ";
            str = str + "Coins: " + coins;
            return str;
        }

    }
}