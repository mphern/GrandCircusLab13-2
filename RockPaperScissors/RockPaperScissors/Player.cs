using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        public abstract string PlayerName { get; }
    
        public Player()
        {   
            
        }
  
        public abstract Roshambo GenerateRoshambo();
 
    }
}
