using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    class Program
    {        
        PlayerCharacter player = PlayerCharacter.theCharacter; //The static player character object

        static CharacterCreation characterCreation; //Static instantiation of the character creation class. Handles creationg a new character

        static Tutorial tutorial = new Tutorial();

        public static string userInput; //String that represent the players interactions and commands in the game.

        public static bool newgame { get; set; } // New game identifier
        public static bool inProgress { get; set; } // Game currently in progress

        public static bool displayTut { get; set; }//Tells the game to display the tutorial if needed.

        static void Main(string[] args)
        {
            //Creates new instances of all in game objects
            populateGameObjects();
            //Creates a new instance of the character creation class
            characterCreation = new CharacterCreation();
            //sets a new game to be true
            newgame = true;
            //Sets the displayTut to true
            displayTut = true;
            //While the game is a new game in the character creation process
            while(newgame)
            {
                characterCreation.characterCreation();//Calls the character creation method which will present the plater with choices for creating a new character
                newgame = false;//set new game to equal false
                inProgress = true;//and then the game is set to be in progress

            }
            while (inProgress)//while the game is in progress
            {
                if (displayTut)
                {
                    tutorial.startTutorial();
                    displayTut = false;
                }
                UserCommands.textCommand(Console.ReadLine());//Seeks player input and then performs an action
            }
            
            Console.Read();//Halts game progression before closing the window if the while loop is exited
        }

        static void populateGameObjects()//Creates new instances of all in game objects
        {
            Abilities.populateMasterList(); //Abilities
            JobMasterList.populateJobMasterList(); //Jobs
            Items.populateMasterList(); //Items
            Equipment.populateMasterList(); //Enemies
        }            
    }
}
