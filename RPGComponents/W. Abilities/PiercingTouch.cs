using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class PiercingTouch : WeaponAbilities//Piercing touch improves strength and nulls half of enemy defense whebn attacking
    {
        public PiercingTouch()//The main constructor for the piercing touch ability
        {
            this.abilityName = "Piercing Touch";//The ability name

            this.statToBuff1 = "ATK";//The first attribute to be affected
            this.buffIncrease1 = 2;//The increase or decrease for tha attribute
            this.statToBuff2 = "MAG";//The second attribute to be affected
            this.buffIncrease2 = 2;//The increase or decrease ammount for the second attribute
        }

        public override void perfromEffect(Enemy target)//Method that ignors half of the enemies physical DEF
        {
            //add logic for attacks to ignore 50% of target enemies def
        }
    }
}
