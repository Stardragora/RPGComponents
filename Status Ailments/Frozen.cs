using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Frozen: StatusAilment//Frozen prevents character activity until unfrozen which happens naturally on a 15% chance or when cured with an item
    {
        public iCharacter affectedCharacter { get; set; }//The affected iCharacter object

        private Random RNG = new Random();//Random number generator 

        public void statusCalculations()//Performs the status effects
        {
            if (RNG.Next(0, 100) > 85)//If a random number is higher than 85 the character is unfrozen
                affectedCharacter.frozen = false;
        }
    }
}
