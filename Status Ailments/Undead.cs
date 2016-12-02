using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Undead: StatusAilment//Characters affected with Undead will be hurt by healing spells and regular damage
    {
        public iCharacter affectedCharacter { get; set; }//The targeted iCharacter Object

        public void statusCalculations()
        {
            //inset logic for switching the role of healing
        }
    }
}
