namespace Monopoly__Mario_Kart_
{
    class Property
    {
        public readonly int cost;
        public readonly string name;
        public readonly int points;
        public readonly int rent;
        public readonly int setrent;
        public readonly string set;
        public Property(string name, int cost, int points, int rent, int setrent, string set)
        {
            this.name = name;
            this.cost = cost;
            this.points = points;
            this.rent = rent;
            this.setrent = setrent;
            this.set = set;
        }
        public override string ToString()
        {
            string s = "";
            s += "Name: " + name + System.Environment.NewLine;
            s += "Points: " + points + System.Environment.NewLine;
            s += "Rent: " + rent + System.Environment.NewLine;
            return s;
        }
    }
}
