using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class GenericEquipment : iEquipment
    {
        //See iEquipment class
        public string type { get; set; }
        public string name { get; set; }
        public string element { get; set; }
        public string weight { get; set; }
        public int current { get; set; }
        public int max { get; set; }

        public string attribute1 { get; set; }
        public string attribute2 { get; set; }
        public string attribute3 { get; set; }
        public string attribute4 { get; set; }

        public int attribute1b { get; set; }
        public int attribute2b { get; set; }
        public int attribute3b { get; set; }
        public int attribute4b { get; set; }

        public int cost { get; set; }
        //Allows for the creation of a new weapon to have pre-specified values when created
        public GenericEquipment(string type, string name, string element, string weight, int cost, string attribute1, string attribute2, string attribute3, string attribute4, int attribute1b, int attribute2b, int attribute3b, int attribute4b, int current, int max)
        {
            this.type = type;
            this.name = name;
            this.element = element;
            this.cost = cost;
            this.weight = weight;

            this.current = current;
            this.max = max;

            this.attribute1 = attribute1;
            this.attribute1b = attribute1b;
            this.attribute2 = attribute2;
            this.attribute2b = attribute2b;
            this.attribute3 = attribute3;
            this.attribute3b = attribute3b;
            this.attribute4 = attribute4;
            this.attribute4b = attribute4b;
        }

        public void equip(string slot, string itemKey)//Handles equipping all equipment
        {
            equipUnequipSB.equipunequipsb.Clear();//Clears the equip and unequip string builder
            switch (slot)//Checks if the input is the correct slot for equipment
            {
                case "HELMET":
                case "CHEST":
                case "HAND":
                case "WAIST":
                case "LEG":
                case "BOOT":
                case "NECK":
                case "WRIST":
                case "RING1":
                case "RING2":
                    PlayerCharacter.theCharacter.playerEquipmentSlots[slot] = PlayerCharacter.theCharacter.playerEquipment[itemKey];//Assigns the equipment item to the correct equipment slot
                    equipUnequipSB.equipunequipsb.Append("You equip the " + PlayerCharacter.theCharacter.playerEquipment[itemKey].name + "\n");//Displays text for equipping the equipment
                    PlayerCharacter.theCharacter.playerEquipment[itemKey].current -= 1;//Removes a quantity of 1 from the equipment inventory
                    PlayerCharacter.theCharacter.playerEquipment[itemKey].applyAttributes();//Adds the attribute bonuses from the equipment to the player
                    break;
                default://If no correct slot is chosen nothing happens
                    break;
            }
            ConsoleSpecificTextDisplay.writeEquipUnequip();
        }
        public void unequip(string slot, string itemkey)//Handles unequipping all equipment
        {
            equipUnequipSB.equipunequipsb.Clear();//Clears the equip and unequip string builder
            switch (slot.ToUpper())//Checks if the input is the correct slot for equipment
            {
                case "HELMET":
                case "CHEST":
                case "HAND":
                case "WAIST":
                case "LEG":
                case "BOOT":
                case "NECK":
                case "WRIST":
                case "RING1":
                case "RING2":
                    foreach (GenericEquipment item in PlayerCharacter.theCharacter.playerEquipment.Values)//Iterates through the player equipment
                    {
                        if (PlayerCharacter.theCharacter.playerEquipmentSlots[slot].name == item.name)//If the current equipment name is equal to the equipped equipments name
                        {
                            PlayerCharacter.theCharacter.playerEquipment[itemkey].current++;//Adds a quantity of 1 to the players equipment inventory for the desired equipment item
                            PlayerCharacter.theCharacter.playerEquipmentSlots[slot].removeAttributes();//Removes the attributes applied by the equipment item
                            PlayerCharacter.theCharacter.playerEquipmentSlots[slot] = Equipment.iEquipmentMasterList["Empty"];//Assigns the players equipment slot to be empty
                            equipUnequipSB.equipunequipsb.Append("You unequip the " + PlayerCharacter.theCharacter.playerEquipment[itemkey].name + "\n");//Writes the unequip message to the console window
                            break;
                        }
                    }
                    break;
                default://If no matches are found nothing happens
                    break;
            }
            ConsoleSpecificTextDisplay.writeEquipUnequip();

        }
    }
}
