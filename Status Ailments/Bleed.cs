using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Bleed : StatusAilment//Deals fair damage to the target iCharacter object
    {
        public iCharacter affectedCharacter { get; set; }//the affected character object

        public void statusCalculations()//Performs the status effects
        {
            if (affectedCharacter.bleed == true)//Checks if the iCharacter is already bleeding
                affectedCharacter.chp -= (affectedCharacter.hp / 24);//if they are they take 1/24th of their total hp
            else//Otherwise they start bleeding
                affectedCharacter.bleed = true;
        }
    }
}
