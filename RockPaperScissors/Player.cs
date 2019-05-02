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
        
        //CONSTRUCTOR
        public Player()
        {
            score = 0;

        }

        //DOES 
        public abstract void MakeChoice();
    }
}
