using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human : Player
    {

        //HAS



        //CONSTRUCTOR
        public Human()
        {
            this.name = null;
            this.score = 0;
            this.gesture = null;
            
        }
        //DOES
        public void EnterName()
        {
            Console.WriteLine("Please enter your name.");
            string yourName = Console.ReadLine();
            this.name = yourName;
        }
        public override void MakeChoice()
        {
            Console.WriteLine("{0}, please choose one of the following moves: rock, paper, scissors, lizard, or spock", this.name);
            string gesture = Console.ReadLine().ToLower();  //Human.gesture = paper
            this.gesture = gesture;

            switch (gesture)
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
                    MakeChoice();
                    break;
            }
        }

    }
}

