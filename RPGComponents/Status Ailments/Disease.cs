using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Disease:StatusAilment//Disease subtracts some from the affected characters current hp and then sets their maximum hp to be equal to the current hp
    {
        public iCharacter affectedCharacter { get; set; }//the affected iCharacter object

        public void statusCalculations()//performs the status effect
        {
            affectedCharacter.chp -= (affectedCharacter.hp / 42);//Minuses the characters hp by one 42nd 
            affectedCharacter.hp = affectedCharacter.chp;//and then sets their maximum HP to = that current
        }
    }
}
