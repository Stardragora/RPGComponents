using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class EnhancedAttack:WeaponAbilities//A weapon ability that enhances physical attack powers
    {
        public EnhancedAttack()//Constructor for the weapon ability
        {
            this.abilityName = "Enhanced Attack";//The name of the weapon ability

            this.statToBuff1 = "ATK";//The first attribute to be increased or decreased
            this.buffIncrease1 = 5;//The ammount the first attribute will be increased or decreased
            this.statToBuff2 = "STR";//The second attribute to be increased or decreased
            this.buffIncrease2 = 5;//The ammount the second attribute will be increased or decreased
        }

        public override void perfromEffect(Enemy target) { }//Enhanced attack does not have a special effect
    }
}
