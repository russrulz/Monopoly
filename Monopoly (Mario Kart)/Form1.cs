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
        }
        int[] Dice = new int[] { 1, 2, 3, 4, 5, 6 };
        string[] Powerdice = new string[] { "Coin", "Bannana", "Green Shell", "Lightning", "Blue Shell", "Coin" };
        public struct race { };
        public struct property { 
            readonly int cost; 
            readonly string name; 
            readonly int points;
            readonly int rent; 
            readonly int setrent;
            readonly string set;
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
        List<race> Races; //add all race cards to set
        List<property> Properties;// add properties to list 
        List<Racer> characters;
        private void Main() {
            while (Races.Count > 0) { 
            
            }
            resetgame();
        }

        private void resetgame()
        {
            //clear all lists and repopulate
            throw new NotImplementedException();
        }
    
    }
}
