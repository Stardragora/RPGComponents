using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Potion : iItem//Base class for potions. Potions are a healing item that can restore MP, HP, or both
    {
        public Potion(string name, string type, int potency, int cost, int current, int max)//Constructor for creating new potions in the item list
        {
            this.name = name;
            this.type = type;
            this.element = "HEAL";
            this.potency = potency;
            this.cost = cost;
            this.current = current;
            this.max = max;
        }

        public void useItem()//Method that handles using the item
        {
            UseItems.potionUse(this.type);
        }
    }
}
