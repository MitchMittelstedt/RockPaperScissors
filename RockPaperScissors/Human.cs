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
            this.humanOrNot = "human";
            
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
            string gesture = Console.ReadLine().ToLower();
            if (!gestures.Contains(gesture))
            {
                MakeChoice();
            }



            //bool IsOneOfGestures = false;
            ////Human.gesture = paper
            //for (int i = 0; i < gestures.Count; i++)
            //{
            //    if (gesture == gestures[i])
            //    {
            //        IsOneOfGestures = true;
            //    }
            //}

            //if (!IsOneOfGestures)
            //{
            //    MakeChoice();
            //}

            this.gesture = gesture;
        }

    }
}

