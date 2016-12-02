using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class Abilities//Contains all the in game abilities
    {
        public static Dictionary<string, iAbility> iAbilityMasterList = new Dictionary<string, iAbility>();//The master dictionary containing all abilities

        public static Dictionary<string, iAbility> warriorAbilities = new Dictionary<string, iAbility>();//All the abilities that the warrior class has access to
        public static Dictionary<string, iAbility> clericAbilities = new Dictionary<string, iAbility>();//All the abilities the cleric class has access to
        public static Dictionary<string, iAbility> wizardAbilities = new Dictionary<string, iAbility>();//All the abilities the wizard class has access to

        public static void populateMasterList()//Adds abilities to their respective list
        {
            //MASTER LIST
            iAbilityMasterList.Add("Double Slash", new DamageAbility("Double Slash", "PHYSICAL", "NON", 0, 10, 5, 1));
            iAbilityMasterList.Add("Fire", new DamageAbility("Fire", "MAGIC", "FIRE", 1, 10, 5, 1));
            iAbilityMasterList.Add("Aim I", new DamageAbility("Aim I", "RANGED", "NON", 2, 10, 5, 1));
            iAbilityMasterList.Add("Heal", new HealAbility("Heal", "HEALING", "HOLY", 3, 10, 5, 1));
            iAbilityMasterList.Add("Leech", new VampireAbility("Leech", "VAMPIRE", "NON", 4, 10, 5, 5, 1));
            iAbilityMasterList.Add("Adrenaline", new BuffAbility("Adrenaline", "BUFF", "NON", "STR", 10, 10, 5, 5, 1));
            //WARRIOR ABILITIES
            warriorAbilities.Add("Double Slash", iAbilityMasterList["Double Slash"]);
            //CLERIC ABILITIES
            clericAbilities.Add("Heal", iAbilityMasterList["Heal"]);
            //WIZARD ABILITIES
            wizardAbilities.Add("Fire", iAbilityMasterList["Fire"]);
        }
    }
}
