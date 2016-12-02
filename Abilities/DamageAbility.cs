using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    //A type of ability that deals damage to the enemies hp
    public class DamageAbility : iAbility
    {
        //see derived from interface
        public string name { get; set; }
        public string type { get; set; }
        public string element { get; set; }

        public int damageType { get; set; }
        public int potency { get; set; }
        public int cost { get; set; }
        public int level { get; set; }

        public DamageAbility(string name, string type, string element, int damageType, int potency, int cost, int level)
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
            //Initializes the damage value with a default value of zero.
            int damage = 0;
            //Checks if the type of the abuility is equal to "MAGIC" or "PHYSICAL" if no match is found the default value is returned
            if (this.type.ToUpper() == "MAGIC")
            { }
            else if (this.type.ToUpper() == "PHYSICAL")
            { }
            else
                Console.WriteLine("NO ABILITY DATA AVAILABLE");
        }
    }
}