﻿using System.Collections.Generic;

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
        public int extramove;
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
            this.extramove = 0;
        }

        public override string ToString()
        {
            string str = "";
            str = str + "Racer: " + racer.name + System.Environment.NewLine;
            str = str + "Races Won : ";
            foreach (Race r in races)
            {
                str = str + r.name + ", ";
            }
            str = str + System.Environment.NewLine;
            str = str + "Property owned: ";
            foreach (Property p in properties)
            {
                str = str + p.name + ", ";
            }
            str = str + System.Environment.NewLine;
            str = str + "Coins: " + coins + System.Environment.NewLine;
            str = str + "Jail: " + jail + System.Environment.NewLine;
            str = str + "Board position: " + boardposition;
            return str;
        }

    }
}
