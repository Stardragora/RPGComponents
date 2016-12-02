using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Paralyzed:StatusAilment//Paralyze will prevent the the player from performing his turn on a 75% chance
    {
        public iCharacter affectedCharacter { get; set; }// The targeted iCharacter object

        private Random RNG = new Random();//Random number generator for the paralyze class
        public void statusCalculations()
        {
            if (RNG.Next(0,100) > 75)//Creates a random number between 0 and 100, if it is over 75 the player will perform their turn.
            { 
                //Perform affectedCharacter turn logic
            }
        }
    }
}
