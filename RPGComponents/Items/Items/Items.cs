using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    //base item properties
    public abstract class iItem
    {
        public string name { get; set; }//Name of the item
        public string type { get; set; }//Type of the item
        public string element { get; set; }//If the item has an element

        public int potency { get; set; }//How powerful the item is
        public int cost { get; set; }//How many items are needed to use the item
        public int current { get; set; }//How many of the item you currently have
        public int max { get; set; }//The maximum ammount of the item you can hold

        void useItem() { } // uses the item. Varies based on item type
    }
}

