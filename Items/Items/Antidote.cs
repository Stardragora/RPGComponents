using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Antitode : iItem//Base class for antidotes. Antidotes cure status ailments
    {
        public Antitode(string name, string type, int potency, int cost, int current, int max)//Constructor for creating new antidotes in the item list
        {
            this.name = name;
            this.type = type;
            this.element = "RESTORE";
            this.potency = potency;
            this.cost = cost;
            this.current = current;
            this.max = max;
        }

        public void useItem()//Method that handles using the item
        {
            UseItems.restoreUse(this.type);
        }
    }
}
