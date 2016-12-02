using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    //Applies stat bonuses to the character equipping the piece of equipment
    public static class ApplyAttributes
    {
        static bool attribute1Set = false;//Tells the game that attribute 1-4 is not set
        static bool attribute2Set = false;
        static bool attribute3Set = false;
        static bool attribute4Set = false;

        public static void applyAttributes(this GenericEquipment generic)//The method that applies the stat bonuses
        {
            switch (generic.attribute1)//Switch statement that compares string values to determine the proper attribute to apply bonuses to. There is a statement for each attribute 1-4
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi += generic.attribute1b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk += generic.attribute1b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def += generic.attribute1b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte += generic.attribute1b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck += generic.attribute1b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag += generic.attribute1b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef += generic.attribute1b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp += generic.attribute1b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str += generic.attribute1b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp += generic.attribute1b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute2)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi += generic.attribute2b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk += generic.attribute2b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def += generic.attribute2b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte += generic.attribute2b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck += generic.attribute2b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag += generic.attribute2b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef += generic.attribute2b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp += generic.attribute2b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str += generic.attribute2b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp += generic.attribute2b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute3)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi += generic.attribute3b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk += generic.attribute3b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def += generic.attribute3b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte += generic.attribute3b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck += generic.attribute3b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag += generic.attribute3b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef += generic.attribute3b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp += generic.attribute3b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str += generic.attribute3b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp += generic.attribute3b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute4)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi += generic.attribute4b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk += generic.attribute4b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def += generic.attribute4b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte += generic.attribute4b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck += generic.attribute4b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag += generic.attribute4b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef += generic.attribute4b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp += generic.attribute4b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str += generic.attribute4b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp += generic.attribute4b;
                    break;
                default:
                    break;
            }
        }

        public static void removeAttributes(this GenericEquipment generic)//Switch statement for removing attributes from the character. Applies to attributes 1-4
        {
            switch (generic.attribute1)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi -= generic.attribute1b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk -= generic.attribute1b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def -= generic.attribute1b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte -= generic.attribute1b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck -= generic.attribute1b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag -= generic.attribute1b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef -= generic.attribute1b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp -= generic.attribute1b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str -= generic.attribute1b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp -= generic.attribute1b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute2)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi -= generic.attribute2b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk -= generic.attribute2b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def -= generic.attribute2b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte -= generic.attribute2b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck -= generic.attribute2b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag -= generic.attribute2b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef -= generic.attribute2b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp -= generic.attribute2b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str -= generic.attribute2b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp -= generic.attribute2b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute3)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi -= generic.attribute3b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk -= generic.attribute3b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def -= generic.attribute3b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte -= generic.attribute3b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck -= generic.attribute3b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag -= generic.attribute3b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef -= generic.attribute3b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp -= generic.attribute3b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str -= generic.attribute3b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp -= generic.attribute3b;
                    break;
                default:
                    break;
            }
            switch (generic.attribute4)
            {
                case "AGI":
                    PlayerCharacter.theCharacter.agi -= generic.attribute4b;
                    break;
                case "ATK":
                    PlayerCharacter.theCharacter.atk -= generic.attribute4b;
                    break;
                case "DEF":
                    PlayerCharacter.theCharacter.def -= generic.attribute4b;
                    break;
                case "INTE":
                    PlayerCharacter.theCharacter.inte -= generic.attribute4b;
                    break;
                case "LUCK":
                    PlayerCharacter.theCharacter.luck -= generic.attribute4b;
                    break;
                case "MAG":
                    PlayerCharacter.theCharacter.mag -= generic.attribute4b;
                    break;
                case "MDEF":
                    PlayerCharacter.theCharacter.mdef -= generic.attribute4b;
                    break;
                case "MP":
                    PlayerCharacter.theCharacter.mp -= generic.attribute4b;
                    break;
                case "STR":
                    PlayerCharacter.theCharacter.str -= generic.attribute4b;
                    break;
                case "HP":
                    PlayerCharacter.theCharacter.hp -= generic.attribute4b;
                    break;
                default:
                    break;
            }
        }
    }
}
