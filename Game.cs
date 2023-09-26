using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Stretch_Zachory
{
    class Game
    {
        //sets maximum players and what the current player count is.
        public int MaxPlayers { get; }

        public int CurrentPlayers { get; set;  }

        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }
        //Kicks a player
        public void KickPlayer()
        {
            CurrentPlayers--;
        }
        //Checks if players are in the queue and will give message if there aren't
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue.");
                }
            }
        }

    }
}
