using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {
       //public List<int> rolls = new List<int>();
        private int[] rolls = new int[20];
        private int currentroll = 0;

        public int score {
            get{
                var score = 0;
                var rindex = 0;
                for(var frames = 0; frame <10; frame++){
                    if(rolls[rindex] + rolls[rindex + 1] == 10) // strike
                    {
                         score += rolls[rindex] + rolls[rindex+1] + rolls[rindex+2];   
                         rindex++;
                    }
                    else if (rolls[index ==10]){ //spare
                        score += rolls[rindex] + rolls[rindex+1] + rolls[rindex+2];
                        rindex += 2;
                    }
                    else{//standard score
                       score += rolls[rindex] + rolls [rindex+1];  
                       rindex += 2;
                    }
                    
                    
                }
             
                return score;       
            }
         }
        public void Roll(int pins)
        {
            rolls[currentroll++] = pins;
            // Add your logic here. Add classes as needed.
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            return score;
        }

        
    }
}
