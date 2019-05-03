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
        public int score;
        public string name;
        public string gesture;
        public List<string> gestures = new List<string>();
        public string humanOrNot;

        //CONSTRUCTOR
        public Player()
        {
            score = 0;
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }

    

        //DOES 
        public abstract void MakeChoice();
    }
}
