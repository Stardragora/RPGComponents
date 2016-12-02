using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Poison: StatusAilment//The poison status ailment does minor damage over time.
    {
        public iCharacter affectedCharacter { get; set; }//The targeted iCharacter object
        private Random rng = new Random();//Random number generator for adding a random amount of damage to the formula

        public void statusCalculations()//Performs the status effect on the affected character
        {
            affectedCharacter.chp -= ((affectedCharacter.hp / 64) + rng.Next(0, 4));//Subtracts one 64th of the affected characters HP plus a random number from 0 to 4
        }
    }
}
