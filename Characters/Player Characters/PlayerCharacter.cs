using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class PlayerCharacter : iCharacter
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
        //OTHER RESISTANCES
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
        public Enemy targetEnemy { get; set; }

        public int[] stats = new int[10];//Creates a interger array to store the attribute scores


        public Dictionary<string, iAbility> playerAbilities = new Dictionary<string, iAbility>();//Creates a dictionary of abilities the player has
        public Dictionary<string, iItem> playerInventory = new Dictionary<string, iItem>();//Creates a dictionary of items the player has
        public Dictionary<string, GenericEquipment> playerEquipment = new Dictionary<string, GenericEquipment>();//Creates a dictionaty of equipment the player has
        public Dictionary<string, GenericWeapon> playerWeapons = new Dictionary<string, GenericWeapon>();//Creates a dictionary of the players held weapons

        public Dictionary<string, GenericEquipment> playerEquipmentSlots = new Dictionary<string, GenericEquipment>(); //Creates a diction



        public Job characterJob { get; set; }

        public GenericEquipment ringSlot1 = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment ringSlot2 = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment earringSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment wristSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment neckSlot = Equipment.iEquipmentMasterList["Empty"];

        public GenericEquipment headSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment chestSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment handSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment waistSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment legSlot = Equipment.iEquipmentMasterList["Empty"];
        public GenericEquipment bootSlot = Equipment.iEquipmentMasterList["Empty"];

        //Creates a copy of the current base class
        public static volatile PlayerCharacter playercharacter;
        PlayerCharacter()
        {
            this.hp = 0;
            this.chp = hp;
            this.mhp = hp;
            this.mp = 0;
            this.cmp = mp;
            this.mmp = mp;
            this.atk = 0;
            this.mag = 0;
            this.str = 0;
            this.inte = 0;
            this.def = 0;
            this.mdef = 0;
            this.agi = 0;
            this.luck = 0;

            stats[0] = hp;
            stats[1] = mp;
            stats[2] = atk;
            stats[3] = mag;
            stats[4] = str;
            stats[5] = inte;
            stats[6] = def;
            stats[7] = mdef;
            stats[8] = agi;
            stats[9] = luck;
            //RESISTANCES
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

            generateEquipmentTable();
        }
        //Access point to the base class cpoy
        public static PlayerCharacter theCharacter
        {
            //gets the return value for the abilities object
            get
            {
                //if the abilitiesClass object is null
                if (playercharacter == null)
                    //it equals a new instantiation of the base class
                    playercharacter = new PlayerCharacter();
                //returns the abilitiesClass object
                return playercharacter;
            }
        }
        public bool mainCharacter { get { return mainCharacter; } private set { mainCharacter = true; } }//Ensures whenever this class is used it is known to be the main character


        private void generateEquipmentTable()//Adds dictionary entries for the player equipment slots and sets them to be to be an empty object
        {
            playerEquipmentSlots.Add("Ring1", ringSlot1);
            playerEquipmentSlots.Add("Ring2", ringSlot2);
            playerEquipmentSlots.Add("Earring", earringSlot);
            playerEquipmentSlots.Add("Wrist", wristSlot);
            playerEquipmentSlots.Add("Neck", neckSlot);
            playerEquipmentSlots.Add("Head", headSlot);
            playerEquipmentSlots.Add("Chest", chestSlot);
            playerEquipmentSlots.Add("Hand", handSlot);
            playerEquipmentSlots.Add("Waist", waistSlot);
            playerEquipmentSlots.Add("Leg", legSlot);
            playerEquipmentSlots.Add("Boot", bootSlot);
        }
    }
}


