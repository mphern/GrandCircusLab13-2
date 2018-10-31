using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Alien : Player
    {

        public override string PlayerName { get{ return "Alien"; } }

        public Alien()
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
