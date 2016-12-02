using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{

    //base ability properties
    public interface iAbility
    {
        string name { get; set; } //The displayed name of the ability
        string type { get; set; } //the displayed type of ability: physical, ranged, magic, etc
        string element { get; set; } //the element of the ability, if one: fire, wind, darkness, light, ect

        int damageType { get; set; } // what type of damage the ability deals: pierce, bludgeoning, ranged-mgic, ect
        int potency { get; set; } // damge value of the ability
        int cost { get; set; } // the cost to the character fot using the ability
        int level { get; set; } // the level the ability is learned at

        void applyDamage(); // decreases enemy hp value using the a special process of damage application for the ability
    }   
}
