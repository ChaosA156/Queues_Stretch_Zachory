using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Stretch_Zachory
{
    class Player
    {
        //publics for Health and GamerTags
        public int Health { get; set; }

        public string GamerTag { get; }

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }
        //Coding for adding players to a server
        public void JoinGame(Game game, Queue<Player> queue)
        {
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("joining Game...");
                game.CurrentPlayers++;
            }
        }

        public override string ToString()
        {
            return GamerTag;
        }
    }
}
