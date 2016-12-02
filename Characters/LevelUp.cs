using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class LevelUp//Class that contains functions and values for leveling a character object in game
    {
        public static void levelup(PlayerCharacter player)//main method for performing the level up function
        {
            Job GenericJob = player.characterJob;//Generic job is declared
            if (player == PlayerCharacter.theCharacter)//Checks if the player is the player character
            {

                //Adds the next levels values to the current attributes for the player character
                player.hp += GenericJob.hpArray[player.level];
                player.chp = player.hp;
                player.mhp = player.hp;
                player.mp += GenericJob.mpArray[player.level];
                player.cmp = player.mp;
                player.mmp = player.mp;
                player.atk += GenericJob.atkArray[player.level];
                player.mag += GenericJob.magArray[player.level];
                player.str += GenericJob.strArray[player.level];
                player.inte += GenericJob.inteArray[player.level];
                player.def += GenericJob.defArray[player.level];
                player.mdef += GenericJob.mdefArray[player.level];
                player.agi += GenericJob.agiArray[player.level];
                player.luck += GenericJob.luckArray[player.level];
            }
            else
            { }

            

            player.playerAbilities.Clear();//Clears and removes all of the players abilities and then readds all abilities the player should have unlocked at their current level
            foreach (iAbility ability in player.characterJob.jobsAbilities.Values)
            {                
                if (player.level >= ability.level)
                    player.playerAbilities.Add(ability.name, ability);
            }
            ConsoleSpecificTextDisplay.displayLevelUpText();
        }
    }
}
