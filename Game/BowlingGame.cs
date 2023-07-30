using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class BowlingGame
    {
        public int Score { get; private set; }
        void Roll(int pins)
        {
            Score += pins;
        }
    }
}
