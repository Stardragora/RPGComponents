using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public abstract class Job//Base template for the job object
    {
        public string jobName { get; set; }//The name of the job
        public string jobDescription { get; set; }//A brief description of the job as seen in the game

        public Dictionary<string, int[]> levelUpDictionary = new Dictionary<string, int[]>();//A dictionary of stat bonuses per level

        public Dictionary<string, iAbility> jobsAbilities = new Dictionary<string, iAbility>();//A list of abilities that the job has access to

        public int[] hpArray = new int[2];//A container for the stat bonuses for HP per level
        public int[] mpArray = new int[2];//A container for the stat bonuses for MP per level
        public int[] atkArray = new int[2];//A container for the stat bonuses for ATK per level
        public int[] magArray = new int[2];//A container for the stat bonuses for MAG per level
        public int[] strArray = new int[2];//A container for the stat bonuses for STR per level
        public int[] inteArray = new int[2];//A container for the stat bonuses for INT per level
        public int[] defArray = new int[2];//A container for the stat bonuses for DEF per level
        public int[] mdefArray = new int[2];//A container for the stat bonuses for MDEF per level
        public int[] agiArray = new int[2];//A container for the stat bonuses for AGI per level
        public int[] luckArray = new int[2];//A container for the stat bonuses for Luck per level

        public GenericWeapon jobWeapon;

    }

    public static class JobMasterList//A master list of all the jobs contained in the game
    {
        public static List<Job> jobMasterList = new List<Job>();//The actual list that contains the jobs

        public static void populateJobMasterList()//Instantiates the job list
        {
            jobMasterList.Add(new Warrior());//Adds the warrior to the job list
            jobMasterList.Add(new Wizard());//Adds the wizard to the job list
            jobMasterList.Add(new Cleric());//Adds the cleric to the job list
        }
    }
}

