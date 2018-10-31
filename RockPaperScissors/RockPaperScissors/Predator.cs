using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Predator : Player
    {
        public override string PlayerName { get { return "Predator"; } }

        public Predator()
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            if (choice == 1)
            {
                return Roshambo.rock;
            }
            else if (choice == 2)
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
