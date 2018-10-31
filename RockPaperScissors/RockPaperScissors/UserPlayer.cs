using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors 
{
    class UserPlayer : Player
    {
        public override string PlayerName { get; }

        public UserPlayer(string playerName)
        {
            PlayerName = playerName;
        }

        public override Roshambo GenerateRoshambo()
        {
            string choice = Validator.Validate("\nRock, Paper, or Scissors? (r/p/s): ", "r", "p", "s");
            if(choice == "r")
            {
                return Roshambo.rock;
            }
            else if(choice == "p")
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }
        }


    }
}
