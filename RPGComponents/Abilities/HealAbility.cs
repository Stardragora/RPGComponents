using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    //A type of ability that heals player hp or deals damage to undead creatures
    public class HealAbility : iAbility
    {
        //see derived from interface
        public string name { get; set; }
        public string type { get; set; }
        public string element { get; set; }

        public int damageType { get; set; }
        public int potency { get; set; }
        public int cost { get; set; }
        public int level { get; set; }

        public HealAbility(string name, string type, string element, int damageType, int potency, int cost, int level)
        {
            this.name = name;
            this.type = type;
            this.element = element;
            this.damageType = damageType;
            this.potency = potency;
            this.cost = cost;
            this.level = level;
        }

        public void applyDamage()
        {
            //Initializes the damage value with a default value of zero. In case of healing damage is treated the same but is added differently
            int damage = 0;
            //Checks if the target is a enemy or friend
            if (this.target == "ENEMY")
            { }
            else if (this.target == "FRIEND")
            { }
            else
                Console.WriteLine("NO ABILITY DATA AVAILABLE");
        }

        //Property for getting the current player target. If a friendly character then sets target to FRIEND and if enemt then ENEMY
        private string target
        {
            get { return target.ToUpper(); }
            set { }
        }
    }
}