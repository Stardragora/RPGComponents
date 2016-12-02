using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class CharacterCreation
    {
        PlayerCharacter player = PlayerCharacter.theCharacter;//The mnain player character object

        public StringBuilder charCreationSB = new StringBuilder();//For displaying and writing any text that needs to be displayed

        private bool charCreated { get; set; }// Turns true once the character is created
        private bool jobUnassigned { get; set; }//Turns to false once the character job is picked
        private bool nameSet { get; set; }//Sets to true once the characters name has been set
        private bool jobSet { get; set; }//Turns to true once the job is set


        public void characterCreation()// Main method for creating the character
        {
            //Initializes the bool values signaling a new character
            charCreated = false;
            jobUnassigned = true;
            nameSet = false;
            jobSet = false;

            writeCharCreationSB("Welcome to a new game. Please type in your name\n" +
                                  "-Your name may only contain up to 12 characters\n\n");//Writes the text for setting a character name
            while (nameSet == false)//If the character has not set a valid name the game will keep replaying this part of the code
            {
                player.name = Console.ReadLine();//Allows the player to enter a name
                if (player.name.Length < 13) // then checks the length on the name and if it is under 13 characters
                    nameSet = true; // set the name to the character
            }
            writeCharCreationSB("Welcome " + player.name + " you have a great journey ahead of you.\n"
                +             "But first, what is your profesion?\n");//Asks the player to choose a job
            writeCharCreationSB("CHOICES: Warrior\n"
                            + "         Cleric\n"
                            + "         Wizard");//Shows the player the jobs they can pick
            while (jobSet == false)//Sets teh players job and keeps trying while the player is not assigned a job
            {
                player.job = Console.ReadLine();//Gets the player input for which job they would like to use for their main character
                switch(player.job.ToUpper())
                {
                    case "WARRIOR"://If player input is warrior
                        player.characterJob = new Warrior();//Sets the player job to warrior
                        jobSet = true;//and sets the jobset trigger to true
                        break;
                    case "CLERIC"://If player input is cleric
                        player.characterJob = new Cleric();//sets the player job to cleric
                        jobSet = true;//and sets the jobset trigger to true
                        break;
                    case "WIZARD"://If player input is wizard
                        player.characterJob = new Wizard();//sets the player job to wizard
                        jobSet = true;//and sets the jobset trigger to true
                        break;
                    default://If the player input doesnt match any option this is the default
                        jobSet = false;//Sets tje jobset trigger to false
                        break;
                }
            }
            createCharacter();//Calls the character creations method

            writeCharCreationSB("\n\nWelcome to the game " + PlayerCharacter.theCharacter.name
                            + "\nYour Stats are as follows:\n");//Writes the welcome message to the player
            ConsoleSpecificTextDisplay.displayCharacterStats();//Writes the character stats to the screen
            writeCharCreationSB("\nYour abilities are:\n");
            foreach (iAbility ability in PlayerCharacter.theCharacter.playerAbilities.Values)
            {
                writeCharCreationSB(ability.name + "\n");//Writes all the characters abilities to the screen
            }
            //Writes the obtained items and equipment to the game screen
            writeCharCreationSB("Here is your item and equipment starter pack:\n" +
                              "ITEMS:\n");
            ObtainItemorEquipment.obtainItem("Potion", 5);
            ObtainItemorEquipment.obtainItem("Antidote", 5);
            ObtainItemorEquipment.obtainItem("Ether", 5);
            writeCharCreationSB("EQUIPMENT:");
            ObtainItemorEquipment.obtainEquipment("Iron Ring", 1);
            ObtainItemorEquipment.obtainEquipment("Iron Helmet", 1);
            ObtainItemorEquipment.obtainEquipment("Iron Breastplate", 1);
        }


        private void createCharacter()//Sets the character stats and job and then levels the player once.
        {
            charCreationSB.Clear();

            player.job = player.characterJob.jobName;
            player.agi = 0;
            player.atk = player.characterJob.jobWeapon.atk;
            player.def = 0;
            player.dHP = "";
            player.dMP = "";
            player.inte = 0;
            player.level = 1;
            player.luck = 0;
            player.mag = 0;
            player.mdef = 0;
            player.str = 0;

            player.characterJob.jobWeapon.wa1.performAttributeAlterations(player);

            LevelUp.levelup(player);//Levels up the player
        }

        private void writeCharCreationSB(string stringToWrite)//Handles writing all text from this class to the game screen
        {
            charCreationSB.Clear();
            charCreationSB.Append(stringToWrite);
            Console.WriteLine(charCreationSB);
        }
    }
}
