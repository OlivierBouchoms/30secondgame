namespace thirtysecondgame
{
    public class Round
    {
        private Player player;
        private static int currentplayer;

        public Player Player { get => player; set => player = value; }
        public static int Currentplayer { get => currentplayer; }

        public Round(Game game)
        {
            //bepaal de huidige speler
            Player = game.PlayerList[currentplayer];
            if (currentplayer == game.PlayerList.Count - 1)
            { 
                currentplayer = 0;
            }
            else
            {
                currentplayer++;
            }
        }

    }
}
