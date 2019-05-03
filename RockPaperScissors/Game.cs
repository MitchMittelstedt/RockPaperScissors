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
        public Player playerOne;
        Player playerTwo;

        //CONSTRUCTOR
        public Game()
        {
            playerOne = new Human();

        }
        //DOES

        public void GetRules()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("Rock Paper Scissors Lizard Spock");
            Console.WriteLine("\nRules for Rock, Paper, Scissors, Lizard, Spock: This is a 2-player game. You may play against a computer or against another human.");
            Console.WriteLine("\nHow To Win: \n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard \n Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard \n Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, Rock crushes Scissors");
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
            if (numberOfPlayers == 1)
            {
                playerTwo = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                playerTwo = new Human();
                Console.WriteLine("Player 2, enter your name.");
                playerTwo.name = Console.ReadLine();
            }
        }


        public void PickGestures()
        {
            playerOne.MakeChoice();
            if (playerTwo.humanOrNot == "computer")
            {
                switch (playerOne.gesture)
                {
                    case "rock":
                        Console.WriteLine("You chose rock.");
                        break;
                    case "paper":
                        Console.WriteLine("You chose paper.");
                        break;
                    case "scissors":
                        Console.WriteLine("You chose scissors.");
                        break;
                    case "lizard":
                        Console.WriteLine("You chose lizard.");
                        break;
                    case "spock":
                        Console.WriteLine("You chose Spock.");
                        break;
                    default:
                        playerOne.MakeChoice();
                        break;
                }
            }
            else if (playerTwo.humanOrNot == "human")
            {
                Console.Clear();
            }

            playerTwo.MakeChoice();
            if (playerTwo.humanOrNot == "computer")
            {
                switch (playerTwo.gesture)
                {
                    case "rock":
                        Console.WriteLine("Spagooters >:D chose rock.");
                        break;
                    case "paper":
                        Console.WriteLine("Spagooters >:D chose paper.");
                        break;
                    case "scissors":
                        Console.WriteLine("Spagooters >:D chose scissors.");
                        break;
                    case "lizard":
                        Console.WriteLine("Spagooters >:D chose lizard.");
                        break;
                    case "spock":
                        Console.WriteLine("Spagooters >:D chose Spock.");
                        break;
                    default:
                        playerTwo.MakeChoice();
                        break;
                }
            }
        }

        public void DetermineRoundWinner()
        {
            bool roundComplete = true;

            //somewhere in here 
            PickGestures();
            do
            {
                if (playerOne.gesture == playerTwo.gesture)
                {
                    Console.WriteLine($"{playerOne.name} and {playerTwo.name} drew a draw! Try again.");
                    roundComplete = false;
                    PickGestures();
                }
                else if ((playerOne.gesture == "rock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "rock" && playerTwo.gesture == "lizard") ||
                    (playerOne.gesture == "paper" && playerTwo.gesture == "rock") || (playerOne.gesture == "paper" && playerTwo.gesture == "spock") ||
                    (playerOne.gesture == "scissors" && playerTwo.gesture == "paper") || (playerOne.gesture == "scissors" && playerTwo.gesture == "lizard") ||
                    (playerOne.gesture == "lizard" && playerTwo.gesture == "spock") || (playerOne.gesture == "lizard" && playerTwo.gesture == "paper") ||
                    (playerOne.gesture == "spock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "spock" && playerTwo.gesture == "rock"))
                {
                    roundComplete = true;
                    Console.WriteLine($"{playerOne.name} won this round! Sorry, {playerTwo.name}!");
                    playerOne.score++;

                }
                else
                {
                    roundComplete = true;
                    Console.WriteLine($"{playerTwo.name} won this round! Sorry, {playerOne.name}");
                    playerTwo.score++;

                }
            }
            while (!roundComplete);
            
            DisplayScore();

            }

        public void DisplayScore()
        {
            Console.WriteLine($"{playerOne.name}'s score is {playerOne.score}. {playerTwo.name}'s score is {playerTwo.score}");
        }

        public void RestartQuestion()
        {
            Console.WriteLine("Do you want to restart the game?");
            string restartAnswer = Console.ReadLine();

            switch(restartAnswer)
            {
                case "yes":
                    PlayGame();
                    break;
                case "no":
                    return;
                default:
                    RestartQuestion();
                    break;
            }
        }


        public void PlayGame()
        {
            Console.Clear();
            do
            {
                GetRules();
                int numberOfPlayers = GetNumberOfPlayers();
                SetupPlayers(numberOfPlayers);
                while (playerOne.score < 3 && playerTwo.score < 3)
                {
                    DetermineRoundWinner();
                }
                //playerOne.score = 0;
                //playerTwo.score = 0;
            }
            while (playerOne.score == 0 && playerTwo.score == 0);
            playerOne.score = 0;
            playerTwo.score = 0;
            RestartQuestion();
        }
    }
}
