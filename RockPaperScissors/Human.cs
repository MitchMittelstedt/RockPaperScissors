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
            string gesture = Console.ReadLine();  //Human.gesture = paper
            this.gesture = gesture;

            switch (gesture)
            {
                case "rock":
                    Console.WriteLine("You chose rock.");
                case "paper":
                    Console.WriteLine("You chose paper.");
                case "scissors":
                    Console.WriteLine("You chose scissors.");
                case "lizard":
                    Console.WriteLine("You chose lizard.");
                case "spock":
                    Console.WriteLine("You chose spock.");

            }
        }

    }
}

