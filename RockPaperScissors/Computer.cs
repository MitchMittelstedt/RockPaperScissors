using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Computer : Player
    {
        int compChoice;
        Random random;

        //CONSTRUCTOR
        public Computer()
        {
            this.score = 0;
            this.name = "Spagooters >:D";
            random = new Random();
            this.humanOrNot = "computer";
        }

        //DOES

        public void RandomNumber()
        {
            compChoice = random.Next(0, 5);
        }

        public override void MakeChoice()
        {
            RandomNumber();
            this.gesture = gestures[compChoice];

        }

    }
}
