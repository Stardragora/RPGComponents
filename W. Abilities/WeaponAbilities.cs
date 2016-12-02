using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public abstract class WeaponAbilities//The base class for all weapon abilities
    {
        public string abilityName { get; set; }//String that represents the abilities name
        public string statToBuff1 { get; set; }//a string that represents the attribute to be increased
        public int buffIncrease1 { get; set; }//a int that represents the total increase to attribute1
        public string statToBuff2 { get; set; }//a string that represents the second attribute to be increased
        public int buffIncrease2 { get; set; }//a int that represents the total increase to attribute2

        public void performAttributeAlterations(PlayerCharacter player)//A shared method that applies the stat bonueses given by the weapon ability
        {
            string attribute;//blank string representing all attributes
            int bonus;//A interger representing the attribute increase ammount

            for (int i = 0; i < 2; i++)//A for loop that stops when i is equal to 2
            {
                if (i == 0)//If i is equal to 0  the first attribute is affected
                {
                    attribute = statToBuff1;//Sets attribute to equal the first stat to buff
                    bonus = buffIncrease1;//Bonus is set to be the increase ammount for attribute1
                }
                else//Otherwise they are set to be the second attribute
                {
                    attribute = statToBuff2;
                    bonus = buffIncrease2;
                }
                switch (attribute)//A switch statement that uses the assigned above attribute and bonus value to apply the attribute
                {
                    case "ATK"://Player attack
                        player.atk += bonus;
                        break;
                    case "MAG"://Player magic
                        player.mag += bonus;
                        break;
                    case "STR"://Player strength
                        player.str += bonus;
                        break;
                    case "INTE"://Player intelligence
                        player.inte += bonus;
                        break;
                    case "DEF"://Player defense
                        player.def += bonus;
                        break;
                    case "MDEF"://player magic defense
                        player.mdef += bonus;
                        break;
                    case "AGI"://player agility
                        player.agi += bonus;
                        break;
                    case "LUCK"://player luck
                        player.luck += bonus;
                        break;
                    default:
                        break;
                }
            }
        }
        public void removeAttributeAlterations(PlayerCharacter player)//A shared method for removing stat attributes when the weapon ability is no longer valid
        {
            string attribute;//blank string representing all attributes
            int bonus;//A interger representing the attribute increase ammount

            for (int i = 0; i < 2; i++)//A for loop that stops when i is equal to 2
            {
                if (i == 0)// If i is equal to 0  the first attribute is affected
                {
                    attribute = statToBuff1;//Sets attribute to equal the first stat to buff
                    bonus = buffIncrease1;//Bonus is set to be the increase ammount for attribute1
                }
                else//Otherwise they are set to be the second attribute
                {
                    attribute = statToBuff2;
                    bonus = buffIncrease2;
                }
                switch (attribute)//A switch statement that uses the assigned above attribute and bonus value to remove the attribute bonus
                {
                    case "ATK"://player attack
                        player.atk -= bonus;
                        break;
                    case "MAG"://player magic
                        player.mag -= bonus;
                        break;
                    case "STR"://player strength
                        player.str -= bonus;
                        break;
                    case "INTE"://player intelligence
                        player.inte -= bonus;
                        break;
                    case "DEF"://player defense
                        player.def -= bonus;
                        break;
                    case "MDEF"://player magic defense
                        player.mdef -= bonus;
                        break;
                    case "AGI"://player agility
                        player.agi -= bonus;
                        break;
                    case "LUCK"://player luck
                        player.luck -= bonus;
                        break;
                    default:
                        break;
                }
            }
        }
        public abstract void perfromEffect(Enemy target);//An abstract method for performing the weapon ability effects
    }
}

