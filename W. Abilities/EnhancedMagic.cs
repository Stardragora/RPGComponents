using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class EnhancedMagic : WeaponAbilities//Enhanced magic improves the casters magical prowess
    {
        public EnhancedMagic()//Constructor for the Enhanced magic class
        {
            this.abilityName = "Enhanced Magic";//The weapon ability name

            this.statToBuff1 = "MAG";//The first attribute to be increased or decreased
            this.buffIncrease1 = 5;//The ammount the first attribute will be increased or decreased
            this.statToBuff2 = "INTE";//The second attribute to be increased or decreased
            this.buffIncrease2 = 5;//The ammount the second attribute will be increased or decreased
        }

        public override void perfromEffect(Enemy target) { }//Enhanced magic does not have a special effect
    }
}
