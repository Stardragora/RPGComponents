using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Petrified:StatusAilment//Pterify stops all character activity after 3 turns
    {
        public iCharacter affectedCharacter { get; set; }//The affected iCharacter object   

        public void statusCalculations()//Performs the status effects
        {
            if (affectedCharacter.petrifyTurnCount < 3)//Checks if the characters petrify turn count is less than 3
            {
                affectedCharacter.petrifyTurnCount++;//Increases the petrify turn count by one
                //perform player turn logic
            }
        }
    }
}
