using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {

        //HAS
        public List<string> gestures;
        public int score;
        public string name;
        public string gesture;
        
        //CONSTRUCTOR
        public Player()
        {
            score = 0;
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        //DOES 
        public abstract void AskName();
        public abstract void MakeChoice();
    }
}
