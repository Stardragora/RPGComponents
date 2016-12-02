using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class GenericWeapon : iWeapon//Base class for all weapons
    {
        public iCharacter character;//The character that has the weapon equipped
        public string name { get; set; }//The name of the weapon
        public string weaponType { get; set; }//What kind of weapon it is
        public string damageType { get; set; }//What kind of damage the wepaon does
        public int atk { get; set; }//The attack power of the weapon
        public int level { get; set; }//The weapons level

        public WeaponAbilities wa1;//If the weapon has a weapon ability
        public WeaponAbilities wa2;//If the weapon has a second weapon ability

        public int[] levelArray = new int[16];//Holds the attack values for the weapon at various levels

        public void levelUpWeapon()//levels up the weapon and presents choices for branching into new weapons
        {

        }

    }
}
