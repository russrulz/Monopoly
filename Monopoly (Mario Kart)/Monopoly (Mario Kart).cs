using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
            worker.DoWork += Worker_DoWork;
            worker.WorkerSupportsCancellation = true;
            ComboBoxNumberPlayers.SelectedIndex = 0;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // run all background tasks here
            Main();
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

            Races.Add(new Race("Moo  Moo Meadows", 1, 1, "Take least expensive unowned property", "collect 3 coins", "Toss a green shell", 20));
            Races.Add(new Race("Toads Turnpike", 2, 1, "All Players pay you 2 coins", "Roll number  die collect that many coins", "collect 3 coins", 20));
            Races.Add(new Race("Royal Raceway", 3, 2, "Buy one property from any player for face value", "collect 4 coins", "toss a blue shell", 30));
            Races.Add(new Race("DK Jungle", 4, 2, "send any player including yourself to free parking do not pass go or collect coins", "roll power up die and complete the action", "", 30));
            Races.Add(new Race("Sherbet Land", 5, 3, "Force Property trade between 2 players", "place 1 bannana on 1 of your properties", "", 40));
            Races.Add(new Race("Yoshi Valley", 6, 2, "Put any property up for auction Payment goes to bank", "Roll number die collect that many coins", "", 40));
            Races.Add(new Race("Tick-Tock Clock", 7, 3, "Send any player to jail", "roll powerup die complete the action", "", 50));
            Races.Add(new Race("Rainbow Road", 8, 3, "Choose 1 Grendprix card from any player rerace it", "", "", 100));

            Board.Add(new Space("GO", "GO"));
            Board.Add(new Space("Property", "Mario Kart Stadium"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property", "Water Park"));
            Board.Add(new Space("Item", "Roll number die collect that many coins"));
            Board.Add(new Space("Property", "Sweet sweet Canyon"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property", "Thwomp Ruins"));
            Board.Add(new Space("Jail", ""));
            Board.Add(new Space("Property", "Mario Circuit"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property", "Toad Harbour"));
            Board.Add(new Space("Thwomp", "Drop 2 coins"));
            Board.Add(new Space("Property", "Twisted Mansion"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property", "Shyguy Falls"));
            Board.Add(new Space("Free Parking", "Do Nothing"));
            Board.Add(new Space("Property", "Sunshine Airport"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property", "Dophin Shoals"));
            Board.Add(new Space("Item", "Roll number die collect that many coins"));
            Board.Add(new Space("Property", "Electrodrome"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property", "Mount Ward"));
            Board.Add(new Space("Go To Jail", "jail=true"));
            Board.Add(new Space("Property", "Cloudtop Cruise"));
            Board.Add(new Space("Boost", "roll number die move that many if banana hit stop there"));
            Board.Add(new Space("Property", "Bone-Dry Dunes"));
            Board.Add(new Space("Thwomp", "Drop 2 coins"));
            Board.Add(new Space("Property", "Bowser's Castle"));
            Board.Add(new Space("Super Star", ""));
            Board.Add(new Space("Property", "Rainbow Road"));

            display.Add(txtPlayer1);
            display.Add(txtPlayer2);
            display.Add(txtPlayer3);
            display.Add(txtPlayer4);
            display.Add(txtPlayer5);
            display.Add(txtPlayer6);
            display.Add(txtPlayer7);
            display.Add(txtPlayer8);
        }
        public bool NETWORK = false;
        public bool HOST = false;
        public bool PASSGO = false;
        readonly int[] Dice = new int[] { 1, 2, 3, 4, 5, 6 };
        readonly string[] Powerdice = new string[] { "Coin", "Bannana", "Green Shell", "Lightning", "Blue Shell", "Coin" };
        readonly List<Race> Races = new List<Race>(); //add all race cards to set
        readonly List<Property> Properties = new List<Property>();// add properties to list 
        readonly List<Racer> characters = new List<Racer>();
        readonly List<Player> players = new List<Player>();
        readonly List<Space> Board = new List<Space>();
        readonly List<int> Bananas = new List<int>();
        readonly List<TextBox> display = new List<TextBox>();
        readonly Random rand = new Random();// set randomizer up 
        private int id = 0;
        private int playermove = 0;
        private string playerpower = "";
        private readonly BackgroundWorker worker = new BackgroundWorker();
        Form2 settingsForm = new Form2();
        PlayerInput requestForm = new PlayerInput();
        Form3 selector = new Form3();
        private void Main()
        {
            int laps = 0;
            int currentplayer = 0;
            Draw();
            while (laps < 8)
            {
                if (worker.CancellationPending) { break; }
                if (NETWORK)
                {
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
                    if (players[currentplayer].jail) { players[currentplayer].coins -= 5; }
                    else if (players[currentplayer].PC)
                    { //if current player is pc do turn
                        string power = Rollpowerup();
                        int move = Rollnumber();
                        if (!players[currentplayer].skippower)
                            Usepowerup(power, players[currentplayer]);
                        Moveplayer(move, players[currentplayer]);
                    }
                    else
                    {
                        // wait for player input 
                        if (!Rollbtn.Enabled) { Invoke(new Action(() => { Rollbtn.Enabled = true; })); }
                        while (Rollbtn.Enabled)
                        {
                            if (worker.CancellationPending) { break; }
                        }
                        if (!players[currentplayer].skippower)
                        {
                            Usepowerup(playerpower, players[currentplayer]);
                        }
                        Moveplayer(playermove, players[currentplayer]);
                    }
                }
                if (PASSGO)
                {
                    players[currentplayer].coins += 2;
                    Startrace(Races[laps], currentplayer);
                    laps++;
                    PASSGO = false;
                }
                //increments 'laps' when someone passes go and start the race with the racenumber of 'laps'
                //end turn
                currentplayer++;//move to next player for next turn
                if (currentplayer >= players.Count)
                {//if the list of players has gone around go to the start of the list
                    currentplayer = 0;
                }
                Draw();
            }
            if (!worker.CancellationPending)
            {
                foreach (Player p in players)
                {
                    Console.WriteLine(p);
                }
                MessageBox.Show("Winner is : " + System.Environment.NewLine + Calculate_winner());
            }

        }

        private void Draw()
        {
            for (int i = 0; i < players.Count; i++)
            {
                Invoke(new Action(() => { display[i].Text = players[i].ToString(); }));
            }

        }

        private void Startrace(Race r, int cp)
        {
            List<Player> entrants = new List<Player>();
            for (int i = cp; i < players.Count; i++)
            { //starting with current player loop thru each player
                joinrace(i);
            }
            for (int i = 0; i < cp; i++)// same for rest of players
            {
                joinrace(i);
            }

            //complete race
            List<int> rolls = new List<int>();
            foreach (Player _ in entrants)
            {
                rolls.Add(Rollnumber());
            }
            int firstindex = rolls.IndexOf(rolls.Max());
            rolls.RemoveAt(firstindex);
            int secondindex = rolls.IndexOf(rolls.Max());
            rolls.RemoveAt(secondindex);
            int thirdindex = rolls.IndexOf(rolls.Max());
            entrants[firstindex].races.Add(r);
            switch (r.name)
            {
                case "Moo Moo Meadows":
                    if (Properties.Count > 0)
                    { //reward for winning take least expensive unowned property (free)
                        entrants[firstindex].properties.Add(Properties[0]);
                        Properties.RemoveAt(0);
                    }

                    entrants[secondindex].coins += 3;//second place gains 3 coins

                    Usepowerup("Green Shell", entrants[thirdindex]);//3rd place gets to use a green shell
                    break;
                case "Toads Turnpike":
                    for (int i = 0; i < players.Count; i++)
                    { //each other player pays winniner 2 coins
                        if (i != firstindex)
                        {
                            players[i].coins -= 2;
                            entrants[firstindex].coins += 2;
                        }
                    }

                    entrants[secondindex].coins += Rollnumber();//second place gets xcoins based on number roll

                    entrants[thirdindex].coins += 3;
                    break;
                case "Royal Raceway":
                    Property p = Pickownedproperty(entrants[firstindex]);  //first reward player may buy property from any other player for face value                  
                    Player owner = Findpropertyowner(p);
                    owner.coins += p.cost;
                    entrants[firstindex].coins -= p.cost;
                    entrants[firstindex].properties.Add(p);
                    owner.properties.Remove(p);

                    entrants[secondindex].coins += 4;//second player gains 4 coins

                    Usepowerup("Blue Shell", entrants[thirdindex]);//third player gets to use a blueshell
                    break;
                case "DK Jungle":
                    Player player = Pickplayer(entrants[firstindex], true,"Send player to Free Parking");
                    player.boardposition = 16;

                    Usepowerup(Rollpowerup(), entrants[secondindex]);
                    break;
                case "Sherbet Land":
                    //force a property trade
                    Property tradeunowned = Pickownedproperty(entrants[firstindex]);
                    Property tradeowned = Selectownproperty(entrants[firstindex]);
                    if (tradeowned != null)
                    {
                        Tradepropertys(tradeowned, tradeunowned, entrants[firstindex]);
                    }
                    else
                    {
                        tradeowned = Pickownedproperty(entrants[firstindex]);
                        while (tradeowned == tradeunowned)
                        {
                            tradeowned = Pickownedproperty(entrants[firstindex]);
                        }
                        Tradepropertys(tradeowned, tradeunowned, Findpropertyowner(tradeowned));
                    }

                    Placebananaproperty(entrants[secondindex]);
                    break;
                case "Yoshi Valley":
                    Auction(Pickownedproperty(entrants[firstindex]), null, Findplayersindex(entrants[firstindex]), true);

                    entrants[secondindex].coins += Rollnumber();
                    break;
                case "Tick-Tock Clock":
                    //send a player to jail
                    Player j = Pickplayer(entrants[firstindex], false,"Send Player to Jail");
                    j.jail = true;
                    j.boardposition = 8;

                    Usepowerup(Rollpowerup(), entrants[secondindex]);
                    break;
                case "Rainbow Road":
                    Rerace(entrants[firstindex]);
                    break;
            }

            void joinrace(int i)
            {
                if (NETWORK) { }
                if (players[i].PC && !players[i].jail)
                {//if player is pc and not in jail check if they can afford and join
                    players[i].coins -= r.entrycost;
                    entrants.Add(players[i]);
                }
                else if (!players[i].jail)
                {

                    // ask player if they wish to enter pay fee if they aren't in jail
                    DialogResult d = MessageBox.Show("The Cost is: " + r.entrycost, "Enter the race " + r.racenumber + "?", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        players[i].coins -= r.entrycost;
                        entrants.Add(players[i]);
                    }

                }
            }
        }

        private void Rerace(Player p)
        {
            int cp = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] == p)
                {
                    cp = i;
                }
            }

            //select unowned race
            List<Race> ra = new List<Race>();
            foreach (Race r in Races)
            {
                if (!p.races.Contains(r))
                {
                    ra.Add(r);
                }
            }
            if (p.PC)
            {
                
            }
            else
            {

                //TODO: Player Input
                //TODO: display races to pick form to player and pick 
            }
            int race = rand.Next(ra.Count);
            if (!p.PC) {
                selector.Text = "Select a race to rerace!";
                for (int i = 0; i < Races.Count; i++)
                {
                    selector.buttons[i].Text = Races[i].ToString();
                    selector.buttons[i].Enabled = true;
                }
                selector.ShowDialog();
                race =  selector.retval;
            }
            Startrace(ra[race], cp);

        }

        private void Tradepropertys(Property tradeowned, Property tradeunowned, Player owner)
        {
            Player p = Findpropertyowner(tradeunowned);
            owner.properties.Add(tradeunowned);
            p.properties.Remove(tradeunowned);
            p.properties.Add(tradeowned);
            owner.properties.Remove(tradeowned);

        }

        private Property Selectownproperty(Player p)
        {
            if (p.PC)
            {
                int i = rand.Next(p.properties.Count);
                if (p.properties.Count > 0)
                {
                    return p.properties[i];
                }
                else
                {
                    return null;
                }
            }
            else {
                int s = Runselector(p.properties);
                if (s == -1)
                {
                    return null;
                }
                else {
                    return p.properties[s];
                }
            }
        }



        private Player Findpropertyowner(Property p)
        {
            foreach (Player pl in players)
            {
                if (pl.properties.Contains(p))
                {
                    return pl;
                }
            }
            return null;
        }

        private Property Pickownedproperty(Player player)
        {
            List<Property> pr = new List<Property>();
            foreach (Player p in players)
            {
                if (p != player)
                {
                    foreach (Property prop in p.properties)
                    {
                        pr.Add(prop);
                    }
                }
            }
            //TODO:player input
            //TODO: display property list and request one
            if (player.PC)
            {
                return pr[rand.Next(pr.Count)];//return a random property for pc
            }
            else
            {
                int s = Runselector(pr);
                return pr[s];
            }
        }

        private int Runselector(List<Property> pr)
        {
            selector.Text = "Select a Property";
            for (int i = 0; i < pr.Count; i++)
            {
                selector.buttons[i].Text = pr[i].ToString();
                selector.buttons[i].Enabled = true;
            }
            selector.ShowDialog();
            return selector.retval;
        }

        private void Usepowerup(string power, Player p)
        {
            switch (power)
            {
                case "Coin":
                    if (p.racer.name == "Mario")
                    {
                        //collect 3 or add 3 to number die roll
                            int i = Requestinputnumber(0, 3, p, "Add up to 3 to your die roll or collect 3 coins");
                            p.extramove += i;
                            if (i == 0)
                            {
                                p.coins += 3;
                            }
                        
                    }
                    else if (p.racer.name == "Rosalina")
                    {

                        //add number of players to rosalina
                        p.coins += players.Count;
                        // take one from every other player
                        foreach (Player play in players)
                        {
                            play.coins -= 1;
                            if (play.coins < 0)
                            {
                                Repo(play);
                                //TODO: check if player is below 0 coins after subtracting and request input to sell property to make up the coins
                            }
                        }
                    }
                    else
                    {
                        p.coins += 3;
                    }
                    break;
                case "Bannana"://dk luigi
                    if (p.racer.name == "Donkey Kong")
                    {
                        //remove up to 3 banana's gain +3 per banana
                        if (p.PC)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                int ba = rand.Next(Bananas.Count);
                                if (Board[ba].banana)
                                {//check there is actually a banana
                                    Board[ba].banana = false;
                                    Bananas.Remove(ba);
                                    p.coins += 3;
                                }


                            }
                        }
                        else
                        {
                            //TODO: Player Input
                        }

                    }
                    else if (p.racer.name == "Luigi")
                    {
                        //place banana on property
                        Placebananaproperty(p);

                    }
                    else
                    {
                        //place banana in path (anyspace from start pos to startpos + die roll)
                        if (p.PC)
                        {
                            Placebanana(p.boardposition);
                        }
                        else
                        {//TODO: Player Input
                         //place banana in x or x + die roll where x is starting position
                        }
                    }
                    break;
                case "Green Shell"://yoshi shyguy
                    Player p1 = Findplayer("F", p);
                    p1.coins -= 3;
                    Board[p1.boardposition].coins += 3;
                    if (p.racer.name == "Yoshi")
                    {
                        //player in front -3 yoshi +3
                        p.coins += 3;
                        Board[p1.boardposition].coins -= 3;//pickup coins droped
                    }
                    else if (p.racer.name == "Shy Guy")
                    {
                        // player in front and behind drop 3
                        Player p2 = Findplayer("B", p);
                        p2.coins -= 3;
                        Board[p2.boardposition].coins += 3;
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
                                Repo(pl);
                            }
                            Board[pl.boardposition].coins++;
                        }
                    }
                    if (p.racer.name == "Toad")
                    {
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
                                Repo(pl);
                            }
                        }
                    }
                    else if (p.racer.name == "Metal Mario")
                    {
                        //roll number die again and move
                        int r = Rollnumber();
                        Moveplayer(r, p);
                    }
                    break;
                case "Blue Shell"://bowser peach
                    if (p.racer.name == "Bowser")
                    {
                        //non bowser player with most coins drops 3 
                        //others drop 1 
                        int t = 0;//position in list of players of player with most coins
                        int most = 0;//amount of coins highest coin count has
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i] != p)
                            {
                                if (players[i].coins > most)
                                {
                                    t = i;
                                }
                                players[i].coins--;
                                Board[players[i].boardposition].coins++;
                            }
                        }
                        players[t].coins -= 2;
                        Board[players[t].boardposition].coins += 2;
                    }
                    else if (p.racer.name == "Princess Peach")
                    {
                        //choose 2 players to drop 3
                        if (p.PC)
                        {
                            Player pl = Pickplayer(p);
                            pl.coins -= 3;
                            Board[pl.boardposition].coins += 3;
                            Player p2 = Pickplayer(p, pl,false);
                            p2.coins -= 3;
                            Board[p2.boardposition].coins += 3;
                        }
                        else
                        {
                            //TODO: Player Input
                        }
                    }
                    else
                    {
                        //choose player to drop 3
                        if (p.PC)
                        {
                            Player pl = Pickplayer(p);
                            pl.coins -= 3;
                            Board[pl.boardposition].coins += 3;
                        }
                        else
                        {
                            //TODO: Player Input
                        }
                    }
                        break;
            }
        }

        private void Placebananaproperty(Player p)
        {
            if (p.properties.Count > 0)
            {
                Property pr = Selectownproperty(p);
                Placebanana(FindPropertyBoard(pr.name));
            }
        }
        
        private Player Pickplayer(Player p) => Pickplayer(p, null, false,"");
        private Player Pickplayer(Player p, bool selfpick,string s) => Pickplayer(p, null, selfpick,s);
        private Player Pickplayer(Player p, Player p2,bool selfpick) => Pickplayer(p, p2, selfpick, "");
        private Player Pickplayer(Player p, Player p2,bool selfpick,string s)
        {
            if (p.PC)
            {
                int i = rand.Next(players.Count);
                if (!selfpick)
                {
                    while (players[i] == p || players[i] == p2)
                    {
                        i = rand.Next(players.Count);
                    }
                }
                return players[i];
            }
            else
            {
                selector.Text = "Select a Player to Target "+s;
                for(int i =0; i < players.Count; i++)
                {
                    selector.buttons[i].Text = players[i].ToString();
                    if(players[i] == p) { 
                        if (selfpick)
                        {
                            selector.buttons[i].Enabled = true;
                        }
                    }
                    else if(players[i] != p2)
                    {
                        selector.buttons[i].Enabled = true;
                    }
                    
                }

                selector.ShowDialog();
                return players[selector.retval];
            }
        }

        /// <summary>
        /// Finds the closest player in a given direction
        /// </summary>
        /// <param name="direction">Direction to search "F" for foward or "B" for backwards</param>
        /// <param name="p">player to search from (normally current player)</param>
        /// <returns>Player closest to p</returns>
        private Player Findplayer(string direction, Player p)
        {

            int closest = Findplayersindex(p);
            if (closest == -1)
            {
                return null;
            }

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] != p)
                {
                    if (direction == "F")
                    {
                        if ((players[i].boardposition + Board.Count) % Board.Count >= (players[closest].boardposition + Board.Count) % Board.Count)
                        {//board wrap 
                            closest = i;
                        }
                    }
                    else if (direction == "B")
                    {
                        if ((players[i].boardposition + Board.Count) % Board.Count <= (players[closest].boardposition + Board.Count) % Board.Count)
                        {
                            closest = i;
                        }
                    }
                    else return null;
                }
            }
            return players[closest];
        }

        private int Findplayersindex(Player p)
        {

            for (int i = 0; i < players.Count; i++)
            {
                if (players[i] == p)
                {
                    return i;
                }
            }

            return -1;
        }

        private void Placebanana(int boardposition)
        {
            //TODO: check how many banana exist?
            Board[boardposition].banana = true;
            Bananas.Add(boardposition);
        }

        private void Moveplayer(int r, Player p)
        {
            r += p.extramove;
            p.extramove = 0;
            if (r > 0)
            {
                for (int i = p.boardposition; i < p.boardposition + r; i++)
                {
                    int j = i;
                    if (j >= Board.Count)
                    {
                        j -= Board.Count;
                    }
                    p.coins += Board[j].coins;//collect coins
                    Board[j].coins = 0;
                    if (Board[j].banana)
                    {

                        r = i - p.boardposition;//set board pos to be where banana was hit
                        Bananas.Remove(j);
                        Board[j].banana = false;
                    }

                }
                p.boardposition += r;
                if (p.boardposition >= Board.Count)
                {
                    PASSGO = true;
                    p.boardposition -= Board.Count;
                }
            }
            else {
                //assume bannans and coins don't exist if moving backwards
                p.boardposition += r;
                if (p.boardposition < 0) {//wrap if u passed go backwards
                    p.boardposition = Board.Count + r;
                }
            }

            switch (Board[p.boardposition].type)
            {
                case "Property":
                    // check the name
                    //check if proprty is avalible
                    //buy/auction if avalible
                    //give rent to owner is already owned
                    //check if property is in the banks list of properties
                    if (Checkproperty(Board[p.boardposition].name, null))
                    {
                        //request if u want to buy/auction it
                        bool buy = Buyorauction();
                        //pay amount 
                        //move property to players list of properties
                        for (int i = 0; i < Properties.Count; i++)
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
                                    Auction(Properties[i], null, Findplayersindex(p));
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
                                    if (Checkproperty(property.set, pl))//check if they have the other member of the set and charage set price if they do
                                    {
                                        p.coins -= property.setrent;//charge player that landed on property set rent
                                        pl.coins += property.setrent;
                                    }
                                    else
                                    {// charge standard rent
                                        p.coins -= property.rent;//charge player that landed stndard rent
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
                    Moveplayer(Rollnumber(), p);
                    break;
                case "Item":
                    p.coins += Rollnumber();
                    break;
                case "Super Star"://use chracters superstar ability
                    Superstar(p);
                    break;//do nothing just visiting jail
                case "Jail":
                    break;
                case "Free Parking":
                    break;
                case "GO to Jail":
                    p.jail = true;
                    p.boardposition = 8;
                    break;
            }
        }

        private bool Checkproperty(string name, Player p)
        {
            if (p == null)
            {
                foreach (Property prop in Properties)
                {
                    if (prop.name == name)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (Property prop in p.properties)
                {
                    if (prop.name == name)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private int FindPropertyBoard(string name)
        {
            for (int i = 0; i < Board.Count; i++)
            {
                if (Board[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Buyproperty(Player p, Property property)
        {
            p.coins -= property.cost;//charge player                
            Properties.Remove(property);//remove from banks properties
            p.properties.Add(property);//add property to players inventory
        }

        private void Auction(Property property, Player owner, int start) => Auction(property, owner, start, false);

        private void Auction(Property property, Player owner, int start, bool tobank)
        {
            int value = 0;
            Player winnning = null;
            int i = start;
            while (winnning != players[i])
            {
                if (players[i].coins >= value + 1)
                {//check player has money to bid
                    if (players[i].PC)
                    {
                        if (value + 1 < ((property.points / 10) * 5) || Checkproperty(property.set, players[i]))
                        {
                            value++;
                            winnning = players[i];
                        }
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Bid: " + (value + 1) + " ", "Bid?", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            value++;
                            winnning = players[i];
                        }//TODO:fix reasking
                    }
                }

                i++;
                if (i == players.Count) { i = 0; }//reset to the start of the list for bids if they have looped
            }
            winnning.coins -= value;
            winnning.properties.Add(property);
            if (owner != null)
            {
                owner.properties.Remove(property);
                if (!tobank)
                {
                    owner.coins += value;
                }
            }
            else
            {
                Properties.Remove(property);
            }

        }

        private bool Buyorauction()
        {
            //TODO: Implement input for auctions
            //TODO: Player Input
            return true;
        }

        private void Superstar(Player p)
        {
            switch (p.racer.name)
            {
                case "Bowser": //"Steal 4 Coins"
                    Player pl = Pickplayer(p,false,"Steal 4 Coins");
                    pl.coins -= 4;
                    p.coins += 4;
                    break;
                case "Metal Mario":// "All other players skip next powerup die roll"
                    foreach (Player pla in players)
                    {
                        if (pla != p)
                        {
                            pla.skippower = true;
                        }
                    }
                    break;
                case "Shy Guy"://, "Move up to 3 spaces forward or backward follow rules of space you land on"
                    //get a number from -3 to 3 from player
                    int m = Requestinputnumber(-3, 3, p, "Move either 3 spaces forward or back");
                    if (m != 0)
                    {
                        Moveplayer(m, p);
                    }
                    break;
                case "Yoshi"://, "Collect all coins on the board"
                    foreach (Space sp in Board)
                    {
                        p.coins += sp.coins;
                        sp.coins = 0;
                    }
                    break;
                case "Donkey Kong"://, "You may place 1 bannana on up to 2 properties you own"
                        if (p.properties.Count >= 2)
                        {
                            //pick 2 randomly?
                            //TODO: Limit banana count total
                            int prop1 = FindPropertyBoard(Selectownproperty(p).name);
                            int prop2 = FindPropertyBoard(Selectownproperty(p).name);
                            Placebanana(prop1);
                            Placebanana(prop2);
                            //place banana on 2 
                        }
                        else if (p.properties.Count > 0)
                        {
                            int prop1 = FindPropertyBoard(Selectownproperty(p).name);
                            Placebanana(prop1);
                        }
                    break;
                case "Rosalina"://, "You may move to the next superstar space collecting any coins you pass"

                    for (int i = 0; true; i++)
                    {
                        int r = p.boardposition + i;
                        if (r >= Board.Count)
                        {
                            r -= Board.Count;
                        }
                        p.coins += Board[r].coins;//collect coins on spaces
                        Board[r].coins = 0;
                        if (Board[r].type == "Super Star")
                        {
                            p.boardposition = r;
                            break;//break the loop when superstar space is reached
                        }
                    }
                    break;
                case "Luigi"://, "You may move the the least expensive unowned property and buy or auction it"
                    if (Properties.Count > 0)
                    {
                        p.boardposition = FindPropertyBoard(Properties[0].name);
                        Moveplayer(0, p);
                    }
                    break;
                case "Toad"://, "You may drop up to 5 coins to move that many spaces"
                        int a = Requestinputnumber(0, 5, p,"Drop 0-5 coins to mvoe forward that number");
                        p.coins -= a;
                        Board[p.boardposition].coins += a;
                    if (a != 0)//if not moving don't dup the space effect
                    {
                        Moveplayer(a, p);
                    }
                        break;
                case "Princess Peach"://, "At the end of your turn roll powerup die and coplete the action"
                    Usepowerup(Rollpowerup(), p);
                    break;
                case "Mario"://, "Collect 3 coins then roll number die and move again"
                    p.coins += 3;
                    Moveplayer(Rollnumber(), p);
                    break;
            }
        }

        private int Requestinputnumber(int min, int max, Player p,string request)
        {
            if (!p.PC) {
                for (int i = min; i <= max; i++)
                {
                    foreach (Button btn in requestForm.buttons)
                    {
                        if (btn.Text == i.ToString())
                        {
                            btn.Enabled = true;
                        }
                    }
                }
                requestForm.ShowDialog();

                return requestForm.ret;
            }
            return rand.Next(min, max);
        }

        private void Repo(Player pl)
        {
            if (pl.PC) { }
            //TODO: check sell properties etc
        }

        private int Rollnumber()
        {
            int rnum = rand.Next(Dice.Length);
            return Dice[rnum];
        }

        private string Rollpowerup()
        {
            int rnum = rand.Next(Powerdice.Length);
            return Powerdice[rnum];
        }

        private Player Calculate_winner()
        {
            Player winner = null;
            int winning_score = 0;
            foreach (Player pl in players)
            {
                int score = 0;
                foreach (Property p in pl.properties)
                {
                    score += p.points;
                }
                foreach (Race r in pl.races)
                {
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

        private void Resetgame()
        {
            //clear all lists and repopulate
            Races.Clear();
            Properties.Clear();
            characters.Clear();
            players.Clear();
            Board.Clear();
            settingsForm = new Form2();
            SetupGame();
            Startbtn.Enabled = true;
            Characterselectbtn.Enabled = true;
            foreach (TextBox t in display) { t.Clear(); }
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {

            //int i = 1;
            //select character
            //selectracerplayer(i);
            //select number of opponenets
            for (int i = players.Count; i < Convert.ToInt32(ComboBoxNumberPlayers.Text); i++)
            {
                Selectracerpc(i);
            }
            Startbtn.Enabled = false;
            Characterselectbtn.Enabled = false;
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
                Resetbtn.Enabled = true;
            }
            else
            {
                Startbtn.Enabled = true;
                MessageBox.Show("Game is already running");
            }
        }

        private void Selectracerpc(int i)
        {
            int ra = rand.Next(characters.Count);
            Racer r = characters[ra];
            players.Add(new Player(r, i, true));
            characters.Remove(r);
        }

        private void Selectracer(int r, int id)
        {
            //link player to person that selected it somehow
            players.Add(new Player(characters[r], id, false));
            //remove from list so i can tell what characters are unselected
            characters.RemoveAt(r);
        }

        private void Characterselectbtn_Click(object sender, EventArgs e)
        {
            //open chracter select form and retunr the clicked chracter?

            // Show the settings form
            if (players.Count < Convert.ToInt32(ComboBoxNumberPlayers.SelectedItem))
            {
                settingsForm.ShowDialog();
                for (int i = 0; i < characters.Count; i++)
                {
                    if (settingsForm.Selectedret == characters[i].name)
                    {
                        Selectracer(i, id);
                    }
                }
                //increment id?
                id++;
            }
            if (players.Count >= Convert.ToInt32(ComboBoxNumberPlayers.SelectedItem))
            {
                Characterselectbtn.Enabled = false;
            }

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxNumberPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (players.Count < Convert.ToInt32(ComboBoxNumberPlayers.SelectedItem))
            {
                Characterselectbtn.Enabled = true;
            }
            else if (players.Count > Convert.ToInt32(ComboBoxNumberPlayers.SelectedItem))
            {
                ComboBoxNumberPlayers.SelectedItem = players.Count.ToString();
                Characterselectbtn.Enabled = false;
            }

        }

        private void Rollbtn_Click(object sender, EventArgs e)
        {

            playerpower = Rollpowerup();
            lblpower.Text = "Power-up: " + playerpower;
            playermove = Rollnumber();
            lbldice.Text = "Dice Roll: " + playermove;
            Rollbtn.Enabled = false;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                //if the game is running cancel it
                worker.CancelAsync();
                MessageBox.Show("Game Is running");
            }
            else
            {
                Resetbtn.Enabled = false;
                Resetgame();
            }
        }
    }
}
