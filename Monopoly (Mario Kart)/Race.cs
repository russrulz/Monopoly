namespace Monopoly__Mario_Kart_
{
    class Race
    {
        public readonly string name;
        public readonly int racenumber;
        public readonly int entrycost;
        public readonly string first_reward;
        public readonly string second_reward;
        public readonly string third_reward;
        public readonly int points;
        public Race(string name, int racenumber, int cost, string first, string second, string third, int points)
        {
            this.name = name;
            this.racenumber = racenumber;
            this.entrycost = cost;
            this.first_reward = first;
            this.second_reward = second;
            this.third_reward = third;
            this.points = points;
        }
        public override string ToString()
        {
            string s = "";
            s += "Name: " + name + System.Environment.NewLine;
            s += "Race Number: " + racenumber + System.Environment.NewLine;
            s += "Reward for First: " + first_reward + System.Environment.NewLine;
            s += "Reward for Second: " + second_reward + System.Environment.NewLine;
            s += "Reward for Third: " + third_reward + System.Environment.NewLine;
            s += "Points: " + points;

            return base.ToString();
        }
    }
}
