using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPGComponents
{
    public static class ObtainItemorEquipment//The main class that contains methods and functions for obtaining items or equipment
    {
        public static StringBuilder obtainSB = new StringBuilder();//The string builder for the entire class

        public static void obtainItem(string itemKey, int quantity)//The main method for obtaining items in game
        {
            iItem obtainedItem;//A generic declared item object

            bool alreadyObtained = false;//Makes sure already obtained for the item is false
            bool itemMismatch = false;//and tells the game that their is no mismatch for the item

            obtainSB.Clear();//Clears the string builder for this class
            foreach (string item in PlayerCharacter.theCharacter.playerInventory.Keys)//Looks through all the items in a players inventory
            {
                if (item == itemKey)//If the item matches the item key in the inventory then already obtained is set to true
                {
                    alreadyObtained = true;
                    break;
                }
                else//otherwise already obtained is set to false
                    alreadyObtained = false;
            }
            if (alreadyObtained == true)//If the player already has obtained the item
            {
                //Checks if adding the player has less than the max amount of that item and then adds one if not
                if (PlayerCharacter.theCharacter.playerInventory[itemKey].current + quantity < PlayerCharacter.theCharacter.playerInventory[itemKey].max)
                    PlayerCharacter.theCharacter.playerInventory[itemKey].current++;
                obtainSB.Append("You obtain " + quantity + " " + itemKey + "\n");//Writes text to the string builder stating you obtained the item
            }
            else//If the player does not already have the item
            {
                foreach (string item in Items.iItemMasterList.Keys)//Goes through the list of all items
                {
                    if (item == itemKey)//if the item being obtained matches an item in the list
                    {
                        obtainedItem = Items.iItemMasterList[itemKey].cloneItem();//The generic declared item object is set to be the found item by calling the clone method
                        obtainSB.Append("You obtain " + quantity + " " + itemKey + "\n");//writes to the string builder the item was obtained
                        PlayerCharacter.theCharacter.playerInventory.Add(itemKey, obtainedItem);//Adds the item to the player inventory by calling the clone method for the item
                        PlayerCharacter.theCharacter.playerInventory[item].current++;//adds a quantity of 1 to the players newly obtained item
                        itemMismatch = false; 
                        break;
                    }
                    else//if no match is found, there is an item mismatch
                        itemMismatch = true;
                }
                if (itemMismatch == true)//if an item mismatch has occured the proper text will be displayed
                {
                    obtainSB.Append("That item does not exist" + "\n");
                }
            }
            ConsoleSpecificTextDisplay.displayObtainedItemText();
        }

        public static void obtainEquipment(string equipmentKey, int quantity)//see obtainItem method, they are really the same just for a different type
        {
            GenericEquipment obtainedEquipment;//A generic declared equipment object

            bool alreadyObtained = false;//Makes sure already obtained for the equipment is false
            bool itemMismatch = false;//and tells the game that their is no mismatch for the equipment

            obtainSB.Clear();//Clears the string builder for this class
            foreach (string item in PlayerCharacter.theCharacter.playerEquipment.Keys)
            {
                if (item == equipmentKey)//If the equipment matches the equipment key in the inventory then already obtained is set to true
                {
                    alreadyObtained = true;
                    break;
                }
                else//otherwise already obtained is set to false
                    alreadyObtained = false;
            }
            if (alreadyObtained == true)//If the player already has obtained the equipment
            {
                //Checks if adding the player has less than the max amount of that equipment and then adds one if not
                if (PlayerCharacter.theCharacter.playerEquipment[equipmentKey].current + quantity < PlayerCharacter.theCharacter.playerEquipment[equipmentKey].max)
                    PlayerCharacter.theCharacter.playerEquipment[equipmentKey].current++;
                obtainSB.Append("You obtain " + quantity + " " + equipmentKey + "\n");//Writes text to the string builder stating you obtained the equipment
            }
            else//If the player does not already have the equipment
            {
                foreach (string equipment in Equipment.iEquipmentMasterList.Keys)//Goes through the list of all equipment
                {
                    if (equipment == equipmentKey)//if the equipment being obtained matches an equipment in the list
                    {
                        obtainedEquipment = Equipment.iEquipmentMasterList[equipmentKey].cloneEquipment();//The generic declared equipment object is set to be the found item by calling the clone method
                        obtainSB.Append("You obtain " + quantity + " " + equipmentKey + "\n");//writes to the string builder the item was obtained
                        PlayerCharacter.theCharacter.playerEquipment.Add(equipmentKey, obtainedEquipment);//Adds the equipment to the player inventory
                        PlayerCharacter.theCharacter.playerEquipment[equipmentKey].current++;//adds a quantity of 1 to the players newly obtained equipment
                        itemMismatch = false;
                        break;
                    }
                    else//if no match is found, there is an item mismatch
                        itemMismatch = true;  
                }
                if (itemMismatch == true)//if an equipment mismatch has occured the proper text will be displayed
                {
                    obtainSB.Append("That item does not exist" + "\n");
                }
            }
            ConsoleSpecificTextDisplay.displayObtainedItemText();
        }

        //CLONE METHODS
        public static iItem cloneItem(this iItem itemToClone)//Exstension method for cloning Items
        {
            var itemThatIsCloned = JsonConvert.SerializeObject(itemToClone);//Creates a new object representing the object to be clones
            var newItem = JsonConvert.DeserializeObject<iItem>(itemThatIsCloned);//Creates a new item that is of the same type and properties as the original but as a new object seperate of the other
            return newItem;//Returns the new item
        }

        public static GenericEquipment cloneEquipment(this GenericEquipment equipmentToClone)//Exstension method for cloning Items
        {
            var equipmentThatIsCloned = JsonConvert.SerializeObject(equipmentToClone);//Creates a new object representing the object to be clones
            var equipmentItem = JsonConvert.DeserializeObject<GenericEquipment>(equipmentThatIsCloned);//Creates a new item that is of the same type and properties as the original but as a new object seperate of the other
            return equipmentItem;//Returns the new item
        }

    }
}
