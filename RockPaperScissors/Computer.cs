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

        //CONSTRUCTOR
        public Computer()
        {
            this.score = 0;
            this.name = "Spagooters >:D";
        }

        //DOES

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            int compChoice = random.Next(0, 4);
            return compChoice;
        }

        public override void MakeChoice()
        {
            return;
        }

    }
}
