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
            Name = name;
            Score = 0;
            Turns = 0;
        }

        //properties

        //methodes

        public void IncreaseScore()
        {
            Score += 1;
        }

        public void DecreaseScore()
        {
            if (Score > 0)
            {
                Score -= 1;
            }
        }

        public void ResetScore()
        {
            Score = 0;
        }

        public void IncreaseTurns()
        {
            Turns++;
        }

        public void ResetTurns()
        {
            Turns = 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public string ToStringOverview()
        {
            return Name + " - " + Score;
        }
    }
}

