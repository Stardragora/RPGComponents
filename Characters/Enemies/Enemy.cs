using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Enemy : iCharacter//Base enemy class inheriting from the iCharacter interface. See iCharacter for property descriptions if needed.
    {
        public string name { get; set; }
        public string job { get; set; }
        public string dHP { get; set; }
        public string dMP { get; set; }

        public int hp { get; set; }
        public int chp { get; set; }
        public int mhp { get; set; }
        public int mp { get; set; }
        public int cmp { get; set; }
        public int mmp { get; set; }
        public int level { get; set; }
        public int atk { get; set; }
        public int mag { get; set; }
        public int str { get; set; }
        public int inte { get; set; }
        public int def { get; set; }
        public int mdef { get; set; }
        public int agi { get; set; }
        public int luck { get; set; }
        //RESISTANCES
        public int fireRes { get; set; }
        public int waterRes { get; set; }
        public int lightningRes { get; set; }
        public int windRes { get; set; }
        public int earthRes { get; set; }
        public int iceRes { get; set; }
        public int lightRes { get; set; }
        public int darkRes { get; set; }
        //STATUS RESISTANCES
        public int frostRes { get; set; }
        public int burnRes { get; set; }
        public int paralyzeRes { get; set; }
        public int poisonRes { get; set; }
        public int bleedRes { get; set; }
        public int diseaseRes { get; set; }
        public int petrifyRes { get; set; }
        public int petrifyTurnCount { get; set; }
        public int undeadRes { get; set; }
        //STATUS BOOLS
        public bool frozen { get; set; }
        public bool burnt { get; set; }
        public bool paralyzed { get; set; }
        public bool poisoned { get; set; }
        public bool bleed { get; set; }
        public bool diseased { get; set; }
        public bool petrified { get; set; }
        public bool undead { get; set; }
        public bool mainCharacter { get; set; }
        public Enemy targetEnemy { get; set; }

        //The lists that contain items and equipment dropped by the enemy
        public List<iItem> itemDropTable = new List<iItem>();
        public List<iEquipment> equipmentDropTable = new List<iEquipment>();
        //Constructor that sets default values for the enemy that can later be modified in the respective enemy class
        public Enemy()
        {
            this.fireRes = 0;
            this.waterRes = 0;
            this.lightningRes = 0;
            this.windRes = 0;
            this.earthRes = 0;
            this.iceRes = 0;
            this.lightRes = 0;
            this.darkRes = 0;
            //OTHER RESISTANCES
            this.frostRes = 0;
            this.burnRes = 0;
            this.paralyzeRes = 0;
            this.poisonRes = 0;
            this.bleedRes = 0;
            this.diseaseRes = 0;
            this.petrifyRes = 0;
            this.undeadRes = 0;
            //STATUS BOOLS
            this.frozen = false;
            this.burnt = false;
            this.paralyzed = false;
            this.poisoned = false;
            this.bleed = false;
            this.diseased = false;
            this.petrified = false;
            this.undead = false;

            this.mainCharacter = false;//Signals that this is not the main character
        }
    }
}