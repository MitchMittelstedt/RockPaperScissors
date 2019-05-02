using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Game
    {
        //HAS
        int roundsToWin;
        Player playerOne;
        Player playerTwo;
        List<string> moves = 

        //CONSTRUCTOR
        public Game()
        {
            playerOne = new Human();
            roundsToWin = 2;
        }

        //DOES

        public int GetNumberOfPlayers()
        {
            Console.Write("How many players?");
            int numberOfPlayers = int Parse(Console.Read())
        }
        public void CheckWinner()
        {

            if(playerOne.gesture == playerTwo.gesture)
            {
                // tie
            }
    
        }


    }
}