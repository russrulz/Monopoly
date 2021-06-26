namespace Monopoly__Mario_Kart_
{
    class Space
    {
        public readonly string type;
        public readonly string name;
        public int coins;
        public bool banana;
        public Space(string type, string name)
        {
            this.type = type;
            this.name = name;
            coins = 0;
            banana = false;
        }

    }
}
