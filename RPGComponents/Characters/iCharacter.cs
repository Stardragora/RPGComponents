using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public interface iCharacter// Character object template
    {
        //Attributes the character will use in game. Attributes are as follows..
        /*
         * Name: The name of the character object
         * Job: The role the character plays ie.. Warrior, Wizard, Cleric
         * dHP/dMP: The displayed hitpoints and magicpoints of the character
         * HP: Hitpoints; this is how much damage you can take
         * MP: Magicpoints; this is how many spells you can cast
         * Level: This is the characters level
         * ATK: This is your physical attack power
         * MAG: This is your magical attack power
         * STR: This is how hard you hit
         * INTE: This is how potent your magic is
         * DEF: This is how well you withstand damage
         * MDEF: This is how well you absorb magic damage
         * AGI: How well you move in battle, as well as your evasion modifier
         * LUCK: Do you feel lucky, punk?
         */
        string name { get; set; }
        string job { get; set; }
        string dHP { get; set; }
        string dMP { get; set; }

        int hp { get; set; }
        int chp { get; set; }
        int mhp { get; set; }
        int mp { get; set; }
        int cmp { get; set; }
        int mmp { get; set; }
        int level { get; set; }
        int atk { get; set; }
        int mag { get; set; }
        int str { get; set; }
        int inte { get; set; }
        int def { get; set; }
        int mdef { get; set; }
        int agi { get; set; }
        int luck { get; set; }
        //These determine how effectively you block out elements and status effects
        //RESISTANCES
        int fireRes { get; set; }
        int waterRes { get; set; }
        int lightningRes { get; set; }
        int windRes { get; set; }
        int earthRes { get; set; }
        int iceRes { get; set; }
        int lightRes { get; set; }
        int darkRes { get; set; }
        //STATUS RESISTANCES
        int frostRes { get; set; }
        int burnRes { get; set; }
        int paralyzeRes { get; set; }
        int poisonRes { get; set; }
        int bleedRes { get; set; }
        int diseaseRes { get; set; }
        int petrifyRes { get; set; }
        int petrifyTurnCount { get; set; }
        int undeadRes { get; set; }
        //STATUS EFFECT FLAGS: When true it means that the character has that status effect
        bool frozen { get; set; }
        bool burnt { get; set; }
        bool paralyzed { get; set; }
        bool poisoned { get; set; }
        bool bleed { get; set; }
        bool diseased { get; set; }
        bool petrified { get; set; }
        bool undead { get; set; }

        Enemy targetEnemy { get; set; }//Does not get used for enemies except when confused

    }
}