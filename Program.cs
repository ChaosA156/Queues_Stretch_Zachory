using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Queues_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);

            Queue<Player> waitingToJoinQ = new Queue<Player>();
            //Some of my friends' actual gamertags
            Player p1 = new Player(100, "WarlordMjolnir");
            Player p2 = new Player(100, "Lime_Beaver");
            Player p3 = new Player(100, "ComicalBread23");
            Player p4 = new Player(100, "LocustGrub415");

            //sets players to be able to join the game
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            //All players joined a server... except for WarlordMjolnir, he's playing Apex.
            Console.WriteLine("Players in queue:");
            foreach(Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
            //Lime_Beaver left to play Apex with WarlordMjolnir
            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);


            Console.WriteLine("\nPlayers in queue:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }

        }
    }
}

