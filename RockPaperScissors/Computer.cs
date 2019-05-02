using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {


        //CONSTRUCTOR
        public Computer()
        {
            this.score = 0;
            this.name = "Spagooters";
        }

        public override void MakeChoice()
        {
            Console.WriteLine("Please choose one of the following moves: rock, paper, scissors, lizard, or spock");
            string gesture = Console.ReadLine();  //Computer.gesture = "rock"
            
            //switch (gesture)
            //{
            //    case "rock":
            //        return;
            //    case "paper":
            //        return;
            //    case "scissors":
            //        return;
            //    case "lizard":
            //        return;
            //    case "spock":
            //        return;
            //}
        }

    }
}
