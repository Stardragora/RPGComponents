using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Goblin:Enemy//The Goblin Grunt enemy
    {
        public Goblin()//Constructor for the Goblin Grunt enemy. See iCharacter for a description of the properties
        {
            this.name = "Goblin Grunt";
            this.job = "Goblin";
            this.hp = 40;
            this.chp = hp;
            this.mhp = this.hp;
            this.mp = 25;
            this.cmp = mp;
            this.mmp = this.mp;
            this.dHP = "HP: " + this.chp + " | " + this.mhp;
            this.dMP = "MP: " + this.cmp + " | " + this.mmp;
            this.atk = 10;
            this.mag = 10;
            this.str = 10;
            this.inte = 10;
            this.def = 10;
            this.mdef = 10;
            this.agi = 10;
            this.luck = 10;
            this.level = 1;

            this.itemDropTable.Add(Items.iItemMasterList["Potion"]);
            this.equipmentDropTable.Add(Equipment.iEquipmentMasterList["Gob Ring"]);
        }
    }
}
