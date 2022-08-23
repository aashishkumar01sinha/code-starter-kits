using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {

        private readonly int[] _rolls = new int[21];
        int _currentRoll = 0;
        public void Roll(int pins)
        {
            // Add your logic here. Add classes as needed.
            _rolls[_currentRoll++] = pins;
        }

        public int GetScore()
        {
            // Returns the final score of the game.
            var score = 0;
            var rollIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (_rolls[rollIndex] + _rolls[rollIndex + 1] == 10) //check for spare
                {
                    score = score + 10 + _rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else if (_rolls[rollIndex] == 10) //check for strike
                {
                    score = score + 10 + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                    rollIndex++;
                }
                else
                {
                    score = score + _rolls[rollIndex] + _rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }
            return score;
        }

        public void Roll(int[] pins)
        {
            foreach (var t in pins)
            {
                _rolls[_currentRoll++] = t;
            }
        }
    }
}
