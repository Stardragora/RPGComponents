using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class ConsoleSpecificTextDisplay
    {
        public static StringBuilder sb = new StringBuilder();//Creates a new string builder opbject


        public static void displayLevelUpText()//Displays the level up text to the game window
        {
            sb.Clear();
            sb.Append("You Leveled Up!\n");
            writeSb();
        }

        public static void displayEquippedItems()//Displays the equipped items to the game window
        {
            sb.Clear();
            sb.Append("Currently Equipped Items\n");
            foreach (GenericEquipment item in PlayerCharacter.theCharacter.playerEquipmentSlots.Values)
            {
                sb.Append(item.type + " : " + item.name + "\n");
            }
            writeSb();
        }

        public static void displayJobName()//Displays the characters jobs
        {
            sb.Clear();
            sb.Append("Your job is " + PlayerCharacter.theCharacter.job + "\n");
            writeSb();
        }

        public static void displayCharacterStats()//Displays the characters attributes to the game window
        {
            sb.Clear();
            sb.Append("Character HP: " + PlayerCharacter.theCharacter.hp + "\n");
            sb.Append("Character MP: " + PlayerCharacter.theCharacter.mp + "\n");
            sb.Append("Character ATK: " + PlayerCharacter.theCharacter.atk + "\n");
            sb.Append("Character MAG: " + PlayerCharacter.theCharacter.mag + "\n");
            sb.Append("Character STR: " + PlayerCharacter.theCharacter.str + "\n");
            sb.Append("Character INTE: " + PlayerCharacter.theCharacter.inte + "\n");
            sb.Append("Character DEF: " + PlayerCharacter.theCharacter.def + "\n");
            sb.Append("Character MDEF: " + PlayerCharacter.theCharacter.mdef + "\n");
            sb.Append("Character AGI: " + PlayerCharacter.theCharacter.agi + "\n");
            sb.Append("Character LUCK: " + PlayerCharacter.theCharacter.luck + "\n");
            writeSb();
        }

        public static void writeInventory()//Displays the characters inventory to the game screen
        {
            sb.Clear();
            sb.Append("PLAYER INVENTORY\n");
            foreach (string item in PlayerCharacter.theCharacter.playerInventory.Keys)
            {
                sb.Append(PlayerCharacter.theCharacter.playerInventory[item].name + " : " + PlayerCharacter.theCharacter.playerInventory[item].current + "\n");
            }
            writeSb();
        }

        public static void writeEquipmentInventory()//Displays the character equipment inventory to the game screen
        {
            sb.Clear();
            sb.Append("PLAYER EQUIPMENT\n");
            foreach (string item in PlayerCharacter.theCharacter.playerEquipment.Keys)
            {
                if (PlayerCharacter.theCharacter.playerEquipment[item].current >= 1)
                    sb.Append(PlayerCharacter.theCharacter.playerEquipment[item].name + " : " + PlayerCharacter.theCharacter.playerEquipment[item].current + "\n");
            }
            writeSb();
        }

        public static void writeEquipedEquipment()//Displays the character equipment inventory to the game screen
        {
            sb.Clear();
            sb.Append("PLAYER EQUIPED ITEMS\n");
            foreach (string item in PlayerCharacter.theCharacter.playerEquipmentSlots.Keys)
            {
                if (PlayerCharacter.theCharacter.playerEquipmentSlots[item].name != "")
                    sb.Append(PlayerCharacter.theCharacter.playerEquipmentSlots[item] + ": " + PlayerCharacter.theCharacter.playerEquipmentSlots[item].name + "\n");
            }
            writeSb();
        }

        public static void displayCharacterAbilities()//Displays the character abilities to the game screen
        {
            sb.Clear();
            foreach (var ability in PlayerCharacter.theCharacter.playerAbilities)
            {
                sb.Append("Ability: " + ability.Value.name + "\n");
            }
            writeSb();
        }

        public static void displayObtainedItemText()//Displays text when you obtain an item
        {
            sb.Clear();
            sb.Append(ObtainItemorEquipment.obtainSB + "\n");
            writeSb();
        }

        public static void writeEquipUnequip()//Writes the equip or unequip text
        {
            sb.Clear();
            sb.Append(equipUnequipSB.equipunequipsb);
            writeSb();
        }

        public static void writeSb()//writes the actual text to the game screen
        {
            Console.WriteLine(sb);
        }
    }
}
