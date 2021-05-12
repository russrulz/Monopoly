using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly__Mario_Kart_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGame();
        }

        private void SetupGame()
        {
            characters.Add(new Racer("Bowser", "Steal 4 Coins", "Blue Shell: Player with most coins drops 3 all others drop 1"));
            characters.Add(new Racer("Metal Mario", "All other players skip next powerup die roll", "Lightning: All other players drop 1 coin, Roll number die and move again"));
            characters.Add(new Racer("Shy Guy", "Move up to 3 spaces forward or backward follow rules of space you land on", "Green Shell: the players in front and behind drop 3 coins"));
            characters.Add(new Racer("Yoshi", "Collect all coins on the board", "Green Shell: The player in front drops 3 coins you may collect them without moving"));
            characters.Add(new Racer("Donkey Kong", "You may place 1 bannana on up to 2 properties you own", "Bannana: You may remove any number of bananas collect 3 per banana removed"));
            characters.Add(new Racer("Rosalina", "You may move to the next superstar sapce collecting any coins you pass", "Coin: take 1 coin from each player"));
            characters.Add(new Racer("Luigi", "You may move the the least expensive unowned property and buy or auction it", "Bannana: place a banana on one of your properties"));
            characters.Add(new Racer("Toad", "You may drop up to 5 coins to move that many spaces", "Lightning: All places drop 1 coin and give you 1 coin"));
            characters.Add(new Racer("Princess Peach", "At the end of your turn roll powerup die and coplete the action", "Blue Shell: Choose 2 players to drop 3 coins"));
            characters.Add(new Racer("Mario", "Collect 3 coins then roll number die and move again", "Collect 3 Coins or add up to 3 to your roll"));

            Properties.Add(new property("Rainbow Road", 5, 50, 5, 10, "Bowser's Castle"));
            Properties.Add(new property("Bowser's Castle", 5, 50, 5, 10, "Rainbow Road"));
            Properties.Add(new property("Bone-Dry Dunes", 4, 40, 4, 8, "Cloudtop Cruise"));
            Properties.Add(new property("Cloudtop Cruise", 4, 40, 4, 8, "Bone-Dry Dunes"));
            Properties.Add(new property("Mount Ward", 3, 30, 3, 6, "Electrodrome"));
            Properties.Add(new property("Electrodrome", 3, 30, 3, 6, "Mount Ward"));
            Properties.Add(new property("Dophin Shoals", 3, 30, 3, 6, "Sunshine Airport"));
            Properties.Add(new property("Sunshine Airport", 3, 30, 3, 6, "Dophin Shoals"));
            Properties.Add(new property("Shyguy Falls", 2, 20, 2, 4, "Twisted Mansion"));
            Properties.Add(new property("Twisted Mansion", 2, 20, 2, 4, "Shyguy Falls"));
            Properties.Add(new property("Toad Harbour", 2, 20, 2, 4, "Mario Circuit"));
            Properties.Add(new property("Mario Circuit", 2, 20, 2, 4, "Toad Harbour"));
            Properties.Add(new property("Thwomp Ruins", 1, 10, 1, 2, "Sweet sweet Canyon"));
            Properties.Add(new property("Sweet sweet Canyon", 1, 10, 1, 2, "Thwomp Ruins"));
            Properties.Add(new property("Water Park", 1, 10, 1, 2, "Mario Kart Stadium"));
            Properties.Add(new property("Mario Kart Stadium", 1, 10, 1, 2, "Water Park"));

            Races.Add(new race("Moo  Moo Meadows", 1, 1, "Take least expensive unowned property", "collect 3 coins", "Toss a green shell",20));
            Races.Add(new race("Toads Turnpike",2,1,"All Players pay you 2 coins","Roll number  die collect that many coins","collect 3 coins",20));
            Races.Add(new race("Royal Raceway", 3, 2, "Buy one property from any player for face value", "collect 4 coins", "toss a blue shell", 30));
            Races.Add(new race("DK Jungle",4,2,"send any player including yourself to free parking do not pass go or collect coins","roll power up die and complete the action","",30));
            Races.Add(new race("Sherbet Land",5,3,"Force Property trade between 2 players","place 1 bannana on 1 of your properties","",40));
            Races.Add(new race("Yoshi Valley",6,2,"Put any property up for auction Payment goes to bank","Roll number die collect that many coins","",40));
            Races.Add(new race("Tick-Tock Clock",7,3,"Send any player to jail","roll powerup die complete the action","",50));
            Races.Add(new race("Rainbow Road",8,3,"Choose 1 Grendprix card from any player rerace it","","",100));

            Board.Add(new space("GO","GO"));
            Board.Add(new space("Property", "Mario Kart Stadium"));
            Board.Add(new space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new space("Property", "Water Park"));
            Board.Add(new space("Item", "Roll number die collect that many coins"));
            Board.Add(new space("Property","Sweet sweet Canyon"));
            Board.Add(new space("superstar",""));
            Board.Add(new space("Property","Thwomp Ruins"));
            Board.Add(new space("Jail",""));
            Board.Add(new space("Property","Mario Circuit"));
            Board.Add(new space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new space("Property","Toad Harbour"));
            Board.Add(new space("Thwomp","Drop 2 coins"));
            Board.Add(new space("Property","Twisted Mansion"));
            Board.Add(new space("superstar",""));
            Board.Add(new space("Property","Shyguy Falls"));
            Board.Add(new space("Free Parking", "Do Nothing"));
            Board.Add(new space("Property","Sunshine Airport"));
            Board.Add(new space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new space("Property","Dophin Shoals"));
            Board.Add(new space("Item", "Roll number die collect that many coins"));
            Board.Add(new space("Property","Electrodrome"));
            Board.Add(new space("superstar", ""));
            Board.Add(new space("Property","Mount Ward"));
            Board.Add(new space("Go To Jail","jail=true"));
            Board.Add(new space("Property","Cloudtop Cruise"));
            Board.Add(new space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new space("Property","Bone-Dry Dunes"));
            Board.Add(new space("Thwomp", "Drop 2 coins"));
            Board.Add(new space("Property","Bowser's Castle"));
            Board.Add(new space("superstar", ""));
            Board.Add(new space("Property","Rainbow Road"));


        }
        public bool Network = false;
        public bool Host = false;
        int[] Dice = new int[] { 1, 2, 3, 4, 5, 6 };
        string[] Powerdice = new string[] { "Coin", "Bannana", "Green Shell", "Lightning", "Blue Shell", "Coin" };
        public struct race { 
            public readonly string name;
            public readonly int racenumber;
            public readonly int entrycost; 
            public readonly string first_reward;
            public readonly string second_reward; 
            public readonly string third_reward; 
            public readonly int points;
            public race(string name, int racenumber,int cost,string first,string second,string third,int points) {
                this.name = name;
                this.racenumber = racenumber;
                this.entrycost = cost;
                this.first_reward = first;
                this.second_reward = second;
                this.third_reward = third;
                this.points = points;
            }
        };
        public struct Racer {
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
        public struct player {
            public Racer racer;
            public List<property> properties;
            public int boardposition;
            public List<race> races;
            public int coins;
            public bool jail;
            public int id;
            public player(Racer racer, int id)
            {
                this.racer = racer;
                this.boardposition = 0;
                this.races = new List<race>();
                this.coins = 10;
                this.id = id;
                this.jail = false;
                this.properties = new List<property>();
            }

        }
        public struct property { 
            public readonly int cost; 
            public readonly string name; 
            public readonly int points;
            public readonly int rent; 
            public readonly int setrent;
            public readonly string set;
            public property(string name, int cost, int points, int rent, int setrent , string set)
            {
                this.name = name;
                this.cost = cost;
                this.points = points;
                this.rent = rent;
                this.setrent = setrent;
                this.set = set;
            }
        };
        public struct space { 
            public readonly string type;
            public readonly string name;
            public space(string type, string name)
            {
                this.type = type;
                this.name = name;

            }
        }
        List<race> Races = new List<race>(); //add all race cards to set
        List<property> Properties = new List<property>();// add properties to list 
        List<Racer> characters = new List<Racer>();
        List<player> players = new List<player>();
        List<space> Board = new List<space>();
        private void Main() {
            int laps = 0;
            int currentplayer = 0;
            while (Races.Count > 0) { 

                
                //increments 'laps' when someone passes go and start the race with the racenumber of 'laps'
                //end turn
                currentplayer++;//move to next player for next turn
                if (currentplayer > players.Count){//if the list of players has gone around go to the start of the list
                    currentplayer = 0;
                }
            }
            calculate_winner();
            resetgame();
        }

        private player calculate_winner()
        {
            player winner = new player();
            int winning_score = 0;
            foreach (player pl in players) {
                int score = 0;
                foreach (property p in pl.properties) {
                    score += p.points;
                }
                foreach (race r in pl.races) {
                    score += r.points;
                }
                int c = pl.coins / 5;//calculate how many sets of 5 the player has
                score += c * 10;//award 10 points per set of 5 coins
                if (score > winning_score)
                {
                    winner = pl;
                }
            }

            return winner;
        }

        private void resetgame()
        {
            //clear all lists and repopulate
            throw new NotImplementedException();
        }

        private void startbtn_Click(object sender, EventArgs e){

            int i = 1;
            //select character
            selectracerplayer(i);
            //select number of opponenets
            //netwokring?

        }

        private void selectracerplayer(int id)
        {
            //ask whihc racer they want
            //create UI for showing racers cards
            int r = checkracer();
            selectracer(r,id);
        }

        private int checkracer()
        {
            throw new NotImplementedException();
        }

        private void selectracer(int r,int id)
        {
            //link player to person that selected it somehow
            players.Add(new player(characters[r],id));
            //remove from list so i can tell what characters are unselected
            characters.RemoveAt(r);
            throw new NotImplementedException();
        }
    
    }
}
