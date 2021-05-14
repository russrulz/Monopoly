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

            Properties.Add(new Property("Rainbow Road", 5, 50, 5, 10, "Bowser's Castle"));
            Properties.Add(new Property("Bowser's Castle", 5, 50, 5, 10, "Rainbow Road"));
            Properties.Add(new Property("Bone-Dry Dunes", 4, 40, 4, 8, "Cloudtop Cruise"));
            Properties.Add(new Property("Cloudtop Cruise", 4, 40, 4, 8, "Bone-Dry Dunes"));
            Properties.Add(new Property("Mount Ward", 3, 30, 3, 6, "Electrodrome"));
            Properties.Add(new Property("Electrodrome", 3, 30, 3, 6, "Mount Ward"));
            Properties.Add(new Property("Dophin Shoals", 3, 30, 3, 6, "Sunshine Airport"));
            Properties.Add(new Property("Sunshine Airport", 3, 30, 3, 6, "Dophin Shoals"));
            Properties.Add(new Property("Shyguy Falls", 2, 20, 2, 4, "Twisted Mansion"));
            Properties.Add(new Property("Twisted Mansion", 2, 20, 2, 4, "Shyguy Falls"));
            Properties.Add(new Property("Toad Harbour", 2, 20, 2, 4, "Mario Circuit"));
            Properties.Add(new Property("Mario Circuit", 2, 20, 2, 4, "Toad Harbour"));
            Properties.Add(new Property("Thwomp Ruins", 1, 10, 1, 2, "Sweet sweet Canyon"));
            Properties.Add(new Property("Sweet sweet Canyon", 1, 10, 1, 2, "Thwomp Ruins"));
            Properties.Add(new Property("Water Park", 1, 10, 1, 2, "Mario Kart Stadium"));
            Properties.Add(new Property("Mario Kart Stadium", 1, 10, 1, 2, "Water Park"));

            Races.Add(new Race("Moo  Moo Meadows", 1, 1, "Take least expensive unowned property", "collect 3 coins", "Toss a green shell",20));
            Races.Add(new Race("Toads Turnpike",2,1,"All Players pay you 2 coins","Roll number  die collect that many coins","collect 3 coins",20));
            Races.Add(new Race("Royal Raceway", 3, 2, "Buy one property from any player for face value", "collect 4 coins", "toss a blue shell", 30));
            Races.Add(new Race("DK Jungle",4,2,"send any player including yourself to free parking do not pass go or collect coins","roll power up die and complete the action","",30));
            Races.Add(new Race("Sherbet Land",5,3,"Force Property trade between 2 players","place 1 bannana on 1 of your properties","",40));
            Races.Add(new Race("Yoshi Valley",6,2,"Put any property up for auction Payment goes to bank","Roll number die collect that many coins","",40));
            Races.Add(new Race("Tick-Tock Clock",7,3,"Send any player to jail","roll powerup die complete the action","",50));
            Races.Add(new Race("Rainbow Road",8,3,"Choose 1 Grendprix card from any player rerace it","","",100));

            Board.Add(new Space("GO","GO"));
            Board.Add(new Space("Property", "Mario Kart Stadium"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property", "Water Park"));
            Board.Add(new Space("Item", "Roll number die collect that many coins"));
            Board.Add(new Space("Property","Sweet sweet Canyon"));
            Board.Add(new Space("superstar",""));
            Board.Add(new Space("Property","Thwomp Ruins"));
            Board.Add(new Space("Jail",""));
            Board.Add(new Space("Property","Mario Circuit"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Toad Harbour"));
            Board.Add(new Space("Thwomp","Drop 2 coins"));
            Board.Add(new Space("Property","Twisted Mansion"));
            Board.Add(new Space("superstar",""));
            Board.Add(new Space("Property","Shyguy Falls"));
            Board.Add(new Space("Free Parking", "Do Nothing"));
            Board.Add(new Space("Property","Sunshine Airport"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Dophin Shoals"));
            Board.Add(new Space("Item", "Roll number die collect that many coins"));
            Board.Add(new Space("Property","Electrodrome"));
            Board.Add(new Space("superstar", ""));
            Board.Add(new Space("Property","Mount Ward"));
            Board.Add(new Space("Go To Jail","jail=true"));
            Board.Add(new Space("Property","Cloudtop Cruise"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Bone-Dry Dunes"));
            Board.Add(new Space("Thwomp", "Drop 2 coins"));
            Board.Add(new Space("Property","Bowser's Castle"));
            Board.Add(new Space("superstar", ""));
            Board.Add(new Space("Property","Rainbow Road"));


        }
        public bool NETWORK = false;
        public bool HOST = false;
        int[] Dice = new int[] { 1, 2, 3, 4, 5, 6 };
        string[] Powerdice = new string[] { "Coin", "Bannana", "Green Shell", "Lightning", "Blue Shell", "Coin" };
        List<Race> Races = new List<Race>(); //add all race cards to set
        List<Property> Properties = new List<Property>();// add properties to list 
        List<Racer> characters = new List<Racer>();
        List<Player> players = new List<Player>();
        List<Space> Board = new List<Space>();
        private void Main() {
            int laps = 0;
            int currentplayer = 0;
            while (Races.Count > 0) { 

                if ( NETWORK ) {
                    if (HOST)
                    {
                        //get current players id
                        //check if it is yours if not send out what id turn it is and for everyone else to set to recive
                        //wait for them to complete turn
                        // if id is yours play turn after telling others to wait?
                    }
                    else
                    {
                        //listen for host
                    }
                }
                else
                {
                    if (players[currentplayer].PC)
                    { //if current player is pc do turn
                        string power = rollpowerup();
                        int move = rollnumber();
                        usepowerup(power,players[currentplayer]);
                        usemove(move,players[currentplayer]);
                    }
                    else {// wait for player input 

                    }
                }
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

        private void usemove(int move,Player p)
        {
            throw new NotImplementedException();
        }

        private void usepowerup(string power, Player p)
        {
            switch (power) {
                case "Coin":
                    if (p.racer.name == "Mario")
                    {//collect 3 or move up to 3

                    }
                    else if (p.racer.name == "Rosalina")
                    {

                        //add number of players to rosalina
                        p.coins += players.Count;
                        // take one from every other player
                        foreach (Player pl in players) {
                            pl.coins -= 1;
                            if (pl.coins < 0) { 
                                //TODO: check if player is below 0 coins after subtracting and request input to sell property to make up the coins
                            }
                        }
                    }
                    else {
                        p.coins += 3;
                    }
                    break;
                case "Bannana"://dk luigi
                    if (p.racer.name == "Donkey Kong") {

                    } else if (p.racer.name == "Luigi") {

                    } else {

                    }
                        break;
                case "Green Shell"://yoshi shyguy
                    if (p.racer.name == "Yoshi") {
                        //player in front -3 yoshi +3
                    } else if (p.racer.name == "Shy Guy") { 
                    
                    } else {
                    
                    }
                    break; 
                case "Lightning"://toad metalmario
                    if (p.racer.name == "Toad") { 
                    
                    } else if (p.racer.name == "Metal Mario") {
                    
                    } else {
                        foreach (Player pl in players) {
                            if (pl != p) { 
                                
                            }
                        }
                    }
                    break;
                case "Blue Shell"://bowser peach
                    if (p.racer.name == "Bowser") {
                    
                    } else if (p.racer.name == "Princess Peach") { 
                    
                    } else {
                    
                    }
                    break;
            }
        }

        private int rollnumber()
        {
            var rand = new Random();
            int i = rand.Next(Dice.Length);
            return Dice[i];
        }

        private string rollpowerup()
        {
            var rand = new Random();
            int i = rand.Next(Powerdice.Length);
            return Powerdice[i];
        }

        private Player calculate_winner()
        {
            Player winner = null;
            int winning_score = 0;
            foreach (Player pl in players) {
                int score = 0;
                foreach (Property p in pl.properties) {
                    score += p.points;
                }
                foreach (Race r in pl.races) {
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
            players.Add(new Player(characters[r],id,false));
            //remove from list so i can tell what characters are unselected
            characters.RemoveAt(r);
            throw new NotImplementedException();
        }

        private void characterselectbtn_Click(object sender, EventArgs e)
        {
            //open chracter select form and retunr the clicked chracter?

        }
    }
}
