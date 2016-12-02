using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Empty:WeaponAbilities//Nothing
    {
        public Empty()
        {
            this.abilityName = "EMPTY";

            this.statToBuff1 = "";
            this.buffIncrease1 = 0;
            this.statToBuff2 = "";
            this.buffIncrease2 = 0;
        }

        public override void perfromEffect(Enemy target)
        {
            
        }
    }
}
