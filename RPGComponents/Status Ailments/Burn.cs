using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Burn: StatusAilment//Burn does moderate damage every turn taking into account a characters burn resistance
    {
        public iCharacter affectedCharacter { get; set; }//The affected iCharacter object
        public void statusCalculations()//Performs the status effects
        {
            int burnRes = affectedCharacter.burnRes;//Gets the characters burn resistance
            if (burnRes < 2)// if it is less than 2 it is set to equal 2
                burnRes = 2;

            if (affectedCharacter.burnt == true)//If the character is burnt already
            {
                if (((affectedCharacter.hp / 16) - (affectedCharacter.burnRes / 2)) > 1)//IF the damage from the burn is above 1
                    affectedCharacter.chp -= ((affectedCharacter.hp / 16) - (affectedCharacter.burnRes / 2));//deals 1/16th of the iCharacters hp as damage
                else//if burn damage is 1 or less
                    affectedCharacter.hp -= 1;//deals 1 damage
            }
            else//If the iCharacter is not burnt, they become burnt
                affectedCharacter.burnt = true;
        }
    }
}
