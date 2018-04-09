namespace thirtysecondgame
{
    public class Player
    {
        //fields
        private string name;
        private int score;
        private int turns;

        public string Name { get => name; private set => name = value; }
        public int Score { get => score; private set => score = value; }
        public int Turns { get => turns; private set => turns = value; }

        public Player(string name) //constructor
        {
            this.Name = name;
            this.Score = 0;
            this.Turns = 0;
        }

        //properties

        //methodes

        public void IncreaseScore()
        {
            this.Score += 1;
        }

        public void DecreaseScore()
        {
            if (this.Score > 0)
            {
                this.Score -= 1;
            }
        }

        public void ResetScore()
        {
            this.Score = 0;
        }

        public void IncreaseTurns()
        {
            this.Turns++;
        }

        public void ResetTurns()
        {
            this.Turns = 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public string ToStringOverview()
        {
            return Name + " - " + Score.ToString();
        }
    }
}

