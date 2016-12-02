using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Staff : GenericWeapon//See iWeapon class for property descriptions
    {        
        public Staff()//Constructor for the Staff
        {
            this.name = "Oak Staff";
            this.weaponType = "STAFF";
            this.damageType = "MAGIC";
            this.level = 1;
            this.atk = this.levelArray[level];

            //For each level from 1-15 is the respective attack power of the weapon
            this.levelArray[0] = 0;
            this.levelArray[1] = 10;
            this.levelArray[2] = 15;
            this.levelArray[3] = 20;
            this.levelArray[4] = 30;
            this.levelArray[5] = 40;
            this.levelArray[6] = 50;
            this.levelArray[7] = 60;
            this.levelArray[8] = 70;
            this.levelArray[9] = 85;
            this.levelArray[10] = 100;
            this.levelArray[11] = 115;
            this.levelArray[12] = 130;
            this.levelArray[13] = 145;
            this.levelArray[14] = 165;
            this.levelArray[15] = 185;

            //The weapon abilities the weapon has.
            this.wa1 = new EnhancedMagic();
            this.wa2 = new Empty();
        }        
    }
}

