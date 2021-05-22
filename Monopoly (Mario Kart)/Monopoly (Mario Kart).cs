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
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property","Thwomp Ruins"));
            Board.Add(new Space("Jail",""));
            Board.Add(new Space("Property","Mario Circuit"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Toad Harbour"));
            Board.Add(new Space("Thwomp","Drop 2 coins"));
            Board.Add(new Space("Property","Twisted Mansion"));
            Board.Add(new Space("Super Star",""));
            Board.Add(new Space("Property","Shyguy Falls"));
            Board.Add(new Space("Free Parking", "Do Nothing"));
            Board.Add(new Space("Property","Sunshine Airport"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Dophin Shoals"));
            Board.Add(new Space("Item", "Roll number die collect that many coins"));
            Board.Add(new Space("Property","Electrodrome"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property","Mount Ward"));
            Board.Add(new Space("Go To Jail","jail=true"));
            Board.Add(new Space("Property","Cloudtop Cruise"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property","Bone-Dry Dunes"));
            Board.Add(new Space("Thwomp", "Drop 2 coins"));
            Board.Add(new Space("Property","Bowser's Castle"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property","Rainbow Road"));


        }
        public bool NETWORK = false;
        public bool HOST = false;
        public bool PASSGO = false;
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
            while (laps < 8) { 

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
                        if(! players[currentplayer].skippower)
                            usepowerup(power,players[currentplayer],move);
                        moveplayer(move,players[currentplayer]);
                    }
                    else {// wait for player input 

                    }
                }
                if (PASSGO)
                {
                    players[currentplayer].coins += 2;
                    startrace(laps,currentplayer);
                    laps++;
                    PASSGO = false;
                }
                //increments 'laps' when someone passes go and start the race with the racenumber of 'laps'
                //end turn
                currentplayer++;//move to next player for next turn
                if (currentplayer >= players.Count){//if the list of players has gone around go to the start of the list
                    currentplayer = 0;
                }
            }

            MessageBox.Show("Winner is : " + calculate_winner());
            foreach (Player p in players) {
                Console.WriteLine(p);
            }
           // resetgame();
        }

        private void startrace(int laps,int cp)
        {
            Race r = Races[laps];
            List<Player> entrants = new List<Player>();
            for (int i = cp; i < players.Count;  i++ ) { //starting with current player loop thru each player
                if (NETWORK) { 
                }
                if (players[i].PC && !players[i].jail) {//if player is pc and not in jail check if they can afford and join
                    //if (players[i].coins >= r.entrycost)
                    //{
                        players[i].coins -= r.entrycost;
                        entrants.Add(players[i]);
                    //}
                }
                // ask player if they wish to enter pay fee
            }
            for (int i = 0; i < cp; i++)// same for rest of players
            {
                if (NETWORK)
                {
                }
                if (players[i].PC && !players[i].jail)
                {//if player is pc and not in jail check if they can afford and join
                 //TODO: join checks
                 //if (players[i].coins >= r.entrycost)
                 //{
                    players[i].coins -= r.entrycost;
                        entrants.Add(players[i]);
                 //}
                }
            }

            //complete race
            List<int> rolls = new List<int>();
            foreach (Player p in entrants) {
                rolls.Add(rollnumber());
            }
                int firstindex = rolls.IndexOf(rolls.Max());
                rolls.RemoveAt(firstindex);
                int secondindex = rolls.IndexOf(rolls.Max());
                rolls.RemoveAt(secondindex);
                int thridindex = rolls.IndexOf(rolls.Max());
                entrants[firstindex].races.Add(Races[laps]);
            //TODO: special rewards of cards
        }

        private void usepowerup(string power, Player p,int die)
        {
            switch (power) {
                case "Coin":
                    if (p.racer.name == "Mario")
                    {
                        //collect 3 or add 3 to number die roll
                    }
                    else if (p.racer.name == "Rosalina")
                    {

                        //add number of players to rosalina
                        p.coins += players.Count;
                        // take one from every other player
                        foreach (Player pl in players) {
                            pl.coins -= 1;
                            if (pl.coins < 0) {
                                repo(pl);
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
                        //place banana in path (anyspace from start pos to startpos + die roll)
                        if (p.PC) { placebanana(p.boardposition); }
                        else {//get input from player
                              //
                        }
                    }
                        break;
                case "Green Shell"://yoshi shyguy
                    if (p.racer.name == "Yoshi") {
                        //player in front -3 yoshi +3
                    } else if (p.racer.name == "Shy Guy") { 
                        // player in front and behind drop 3
                    } else {
                        //player in front drop 3 if tie current player pick
                    }
                    break; 
                case "Lightning"://toad metalmario
                    foreach (Player pl in players)
                    {
                        if (pl != p)
                        {
                            pl.coins -= 1;
                            if (pl.coins < 0)
                            {
                                repo(pl);
                            }
                            Board[pl.boardposition].coins++;
                        }
                    }
                    if (p.racer.name == "Toad") {
                        p.coins--;
                        Board[p.boardposition].coins++;
                        //add number of players coins to toad
                        p.coins += players.Count;
                        // take one from every player
                        foreach (Player pl in players)
                        {
                            pl.coins -= 1;
                            if (pl.coins < 0)
                            {
                                repo(pl);
                            }
                        }
                    } else if (p.racer.name == "Metal Mario") {
                        //roll number die again and move
                        int r = rollnumber();
                        moveplayer(r, p);
                    }
                    break;
                case "Blue Shell"://bowser peach
                    if (p.racer.name == "Bowser") {
                        //non bowser player with most coins drops 3 
                        //others drop 1 
                    } else if (p.racer.name == "Princess Peach") { 
                        //choose 2 players to drop 3
                    } else {
                        //choose player to drop 3
                    }
                    break;
            }
        }

        private void placebanana(int boardposition)
        {
            //check how many banana exist?
            Board[boardposition].banana = true;
        }

        private void moveplayer(int r, Player p)
        {
            p.boardposition += r;
            if (p.boardposition >= Board.Count) {
                PASSGO = true;
                p.boardposition -= Board.Count;
            }
            switch (Board[p.boardposition].type) { 
            case "Property":
                    // check the name
                    //check if proprty is avalible
                    //buy/auction if avalible
                    //give rent to owner is already owned
                   // if (!Properties.Any(n => n.name == Board[p.boardposition].name))//check if property is in the banks list of properties
                   if(checkproperty(Board[p.boardposition].name))
                    {
                        //request if u want to buy/auction it
                        bool buy = buyorauction();
                        //pay amount 
                        //move property to playes list of properties
                        for(int i =0; i<Properties.Count; i++)
                        { //find property in list of banks properties
                            if (Properties[i].name == Board[p.boardposition].name)
                            {
                                if (p.PC)
                                {
                                   // if (p.coins >= Properties[i].cost)
                                  //  {
                                        Buyproperty(p, Properties[i]);
                                    //}
                                }
                                else if (buy)
                                {
                                    Buyproperty(p, Properties[i]);
                                }
                                else
                                {
                                    auction(Properties[i]);
                                }
                            }
                        }
                    }
                    else
                    { //find who owns property and pay rent thats aplicable
                        foreach (Player pl in players)
                        {
                            foreach (Property property in pl.properties)
                            {
                                if (Board[p.boardposition].name == property.name)
                                {
                                    if (pl.properties.Any(n => n.name == property.set))//check if they have the other member of the set and charage set price if they do
                                    {
                                        p.coins -= property.setrent;
                                        pl.coins += property.setrent;
                                    }
                                    else
                                    {// charge standard rent
                                        p.coins -= property.rent;
                                        pl.coins += property.rent;
                                    }
                                }
                            }
                        }
                    }
                    break;
            case "Thwomp":
                    p.coins -= 2;
                    Board[p.boardposition].coins += 2;
                break;
            case "GO": //do nothing as it is handled by the pass go code
                break;
            case "Boost":
                moveplayer(rollnumber(), p);
                break;
            case "Item":
                p.coins += rollnumber();
                break;
            case "Super Star"://use chracters superstar ability
                    superstar(p);
                break;//do nothing just visiting jail
            case "Jail":
                break;
            case "Free Parking":
                break;
            case "GO to Jail":
                p.jail = true;
                break;
            }
        }

        private bool checkproperty(string name)
        {
            foreach (Property prop in Properties) {
                if (prop.name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void Buyproperty(Player p, Property property)
        {
                p.coins -= property.cost;//charge player                
                Properties.Remove(property);//remove from banks properties
                p.properties.Add(property);//add property to players inventory
        }

        private void auction(Property property)
        {
            //TODO: Implement Auctions
        }

        private bool buyorauction()
        {
            //TODO: Implement input for auctions
            return true;
        }

        private void superstar(Player p)
        {
            switch (p.racer.name)
            {
                case "Bowser": //"Steal 4 Coins"
                    break;
                case "Metal Mario":// "All other players skip next powerup die roll"
                    foreach (Player pl in players) {
                        if (pl != p) {
                            pl.skippower = true;
                        }
                    }
                    break;
            case "Shy Guy"://, "Move up to 3 spaces forward or backward follow rules of space you land on"
                    //get a number from -3 to 3 from player
                    moveplayer(requestinputnumber(),p); 
                    break;
            case "Yoshi"://, "Collect all coins on the board"
                    foreach (Space s in Board) {
                        p.coins += s.coins;
                        s.coins = 0;
                    }
                    break;
            case "Donkey Kong"://, "You may place 1 bannana on up to 2 properties you own"
                    break;
           case "Rosalina"://, "You may move to the next superstar space collecting any coins you pass"
                    break;
           case"Luigi"://, "You may move the the least expensive unowned property and buy or auction it"
                    break;
           case "Toad"://, "You may drop up to 5 coins to move that many spaces"
                    break;
            case "Princess Peach"://, "At the end of your turn roll powerup die and coplete the action"
                    break;
            case "Mario"://, "Collect 3 coins then roll number die and move again"
                    p.coins += 3;
                    moveplayer(rollnumber(),p);
                    break;
        }
        }

        private int requestinputnumber()
        {
            //TODO: get input
            return 3;
        }

        private void repo(Player pl)
        {
            //TODO: check sell properties etc
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
                    winning_score = score;
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

            //int i = 1;
            //select character
            //selectracerplayer(i);
            //select number of opponenets
            for (int i =0; i < 4; i++)
            {
                selectracerpc(i);
            }
            Main();
        }

        private void selectracerpc(int i)
        {
            Random rand = new Random();
            int ra = rand.Next(rand.Next(characters.Count - 1));
            Racer r =characters[ra];
            players.Add(new Player(r, i, true));
            characters.Remove(r);
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
        }

        private void characterselectbtn_Click(object sender, EventArgs e)
        {
            //open chracter select form and retunr the clicked chracter?

        }

        private void button1_Click(object sender, EventArgs e)
        {
          this.Close();
        }
    }
}
