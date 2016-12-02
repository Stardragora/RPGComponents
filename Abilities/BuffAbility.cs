using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    //A type of ability that increases a single attribute
    public class BuffAbility : iAbility
    {
        //see iAbility for descriptions 
        public string name { get; set; }
        public string type { get; set; }
        public string element { get; set; }

        public int damageType { get; set; }
        public int potency { get; set; }
        public int cost { get; set; }
        public int level { get; set; }

        //The increase amount for the attribute to be buffed
        public int statPotency { get; set; }
        //The attribute to increase
        public string statToBuff1 { get; set; }

        public BuffAbility(string name, string type, string element, string statToBuff1, int damageType, int potency, int statPotency, int cost, int level)//Constructor for the Buff Ability
        {

            //Assigns the properties to values
            this.name = name;
            this.type = type;
            this.element = element;
            this.statToBuff1 = statToBuff1;
            this.damageType = damageType;
            this.potency = potency;
            this.statPotency = statPotency;
            this.cost = cost;
            this.level = level;
        }

        public void applyDamage()//Provides the ability to buff the characters abilities
        {
            if (this.type.ToUpper() == "SBUFF")
            { }
            else
                Console.WriteLine("NO ABILITY DATA AVAILABLE");
        }
    }
}