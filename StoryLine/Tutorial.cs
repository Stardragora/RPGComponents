using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Tutorial//Class that contains all starting information for the player
    {
        StringBuilder tutSB = new StringBuilder();//Tutorials string builder

        public void startTutorial()//The basic tutorial text
        {
            writeTutSB("Welcome to the game " + PlayerCharacter.theCharacter.name + ", before you begin your adventure\n" +
                       "Equipping Items:\n To equip a piece of gear, in the game window type \"E:*Item Name*\" " + "\n" +
                       "Unequipping Items:\n To unequip a piece of gear, in the game window type \"U:*Item Name*\" " + "\n" +
                       "Using Items:\n To use an item from your inventory, in the game window type \"UI:*Item Name*\" " + "\n" +
                       "Display Inventory:\n To display your current items, in the game window type \"I:\" " + "\n" +
                       "Display Equipment Inventory:\n To display the equipment you are currently holding, in the game window type \"EQ:\" " + "\n" +
                       "Display Character Attributes:\n To display your characters stats, in the game window type \"P:\" " + "\n" +
                       "Display Character Abilities:\n To display your characters abilities and skills, in the game window type \"A:\" " + "\n");
            
        }

        private void writeTutSB(string stringToWrite)//Writes the tutorial string builder to the console
        {
            tutSB.Clear();
            tutSB.Append(stringToWrite);
            Console.WriteLine(tutSB);
        }
    }
}
