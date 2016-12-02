using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class UserCommands
    {
        static string iName;
        public static void textCommand(string userInput)//Checks the users input text and then checks the starting letters
        {

            if (userInput.StartsWith("E:"))//Equips items if it starts with E:
            {
                equipCommand(userInput);
            }
            if (userInput.StartsWith("U:"))//Unequips items if it starts with U:
            {
                unequipCommand(userInput);
            }
            if (userInput.StartsWith("I:"))//Displays the characters inventory if it starts with I:
            {
                ConsoleSpecificTextDisplay.writeInventory();
            }
            if (userInput.StartsWith("EQ:"))//Displays the characters equipment if it starts with EQ:
            {
                ConsoleSpecificTextDisplay.writeEquipmentInventory();
            }
            if(userInput.StartsWith("EI:"))//Displays the characters equipment if it starts with EQ:
            {
                ConsoleSpecificTextDisplay.writeEquipedEquipment();
            }
            if (userInput.StartsWith("P:"))//Displays the characters attributes if it starts with P:
            {
                ConsoleSpecificTextDisplay.displayCharacterStats();
            }
            if (userInput.StartsWith("A:"))//Displays the characters abilities if it starts with A:
            {
                ConsoleSpecificTextDisplay.displayCharacterAbilities();
            }
        }

        private static void equipCommand(string userInput)//The main method for handeling the equip command
        {
            string iType = "";

            iName = userInput.Substring(2);
            foreach(var item in PlayerCharacter.theCharacter.playerEquipment.Values)
            {
                if(item.name == iName)
                {
                    if (item.type == "RING")
                    {
                        if (PlayerCharacter.theCharacter.ringSlot1.name == "")
                            iType = "RING1";
                        else if (PlayerCharacter.theCharacter.ringSlot2.name == "")
                            iType = "RING2";
                        else
                            iType = "";
                    }
                    else
                        iType = item.type;
                    if (iType != "")
                        item.equip(iType, iName);
                    else
                        Console.WriteLine("\nYou already have something equipped in this slot");
                }
            }
        }

        private static void unequipCommand(string userInput)//The main method for handeling the unequip command
        {
            string iType = "";
            iName = userInput.Substring(2);

            foreach (var item in PlayerCharacter.theCharacter.playerEquipment.Values)
            {
                if (item.name == iName)
                {
                    if (item.type == "RING")
                    {
                        if (PlayerCharacter.theCharacter.ringSlot1.name != item.name)
                            iType = "RING1";
                        else if (PlayerCharacter.theCharacter.ringSlot2.name != item.name)
                            iType = "RING2";
                    }
                    else
                        iType = item.type;
                    item.unequip(iType, iName);
                }
            }
        }
    }
}
