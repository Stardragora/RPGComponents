using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public interface iWeapon//Template for the weapon class
    {
        string name { get; set; }//The weapons name
        string weaponType { get; set; }//What kind of weapon the weapon is
        string damageType { get; set; }//What kind of damage the weapon does
        
        int atk { get; set; }//Attack power of the weapon
        int level { get; set; }//The level of the weapon
    }    
}

