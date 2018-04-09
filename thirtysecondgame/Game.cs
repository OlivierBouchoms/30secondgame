using System;
using System.Collections.Generic;

namespace thirtysecondgame
{
    public class Game
    {
        //fields
        private List<Player> playerList;
        private int maxscore;

        public Game(int maxscore) //constructor
        {
            playerList = new List<Player>();
            this.maxscore = maxscore;
        }

        public int Maxscore { get => maxscore;}

        //properties

        internal List<Player> PlayerList { get => playerList; private set => playerList = value; }

        //methodes

        public void CreatePlayer(string name)
        {
            Player player = new Player(name); //create object
            playerList.Add(player); //add player to list
        }

        public override string ToString()
        {
            string players = String.Empty;
            foreach (Player player in playerList)
            {
                players += player.ToString();
                players += ", ";
            }
            return "Maxscore: " + Maxscore.ToString() + " Players: " + players;
        }
    }
}
