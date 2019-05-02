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
        int round;
        int roundsToWin;
        Player playerOne;
        Player playerTwo;
        List<string> gestures;

        //CONSTRUCTOR
        public Game()
        {
            playerOne = new Human();
            round = 0;
            roundsToWin = 3;
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }

        //DOES

        public void GetRules()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("\nRules for Rock, Paper, Scissors, Lizard, Spock: This is a 2-player game. You may play against a computer or against another human.");
            Console.WriteLine("\nHow To Win \n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard \n Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard \n Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players? Press 1 to play against the CPU or 2 to play against another human being.");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void SetupPlayers(int numberOfPlayers)
        {
            if(numberOfPlayers == 1)
            {
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                playerTwo = new Human();
            }
        }

        public void CompareGestureToListOfGestures()
        {
            for(int i = 0; i < 5; i++)
            {
                if (playerOne.gesture == gestures[i])
                {

                } 
            }
        }

        public void RoundWinner()
        {

            if(playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("You both drew the same hand! Tie. Try again.");
            }
            else if ((playerOne.gesture == "Rock" && playerTwo.gesture == "Scissors") || (playerOne.gesture == "Rock" && playerTwo.gesture == "Lizard") || (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock") || (playerOne.gesture == "Paper" && playerTwo.gesture == "Spock") || (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper") || (playerOne.gesture == "Scissors" && playerTwo.gesture == "Lizard") || (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock") || (playerOne.gesture == "Lizard" && playerTwo.gesture == "Paper") || (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors") || (playerOne.gesture == "Spock" && playerTwo.gesture == "Rock"))
            {
                Console.WriteLine($"{playerOne.name} won this round! Sorry, Spagooters!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine($"{playerTwo.name} won this round! Sorry, {playerOne.name}");
            }
        }

        public void PlayGame()
        {
            Console.Clear();
            do
            {
                GetRules();
                GetNumberOfPlayers();
                SetupPlayers(GetNumberOfPlayers());
                while (round < 5)
                {
                    playerOne.MakeChoice();
                    playerTwo.MakeChoice();
                    RoundWinner();

                    round++;
                }
            }
            while (playerOne.score == 0 && playerTwo.score == 0);       
        }

    }
}