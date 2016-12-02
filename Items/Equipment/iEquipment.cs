using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    static class equipUnequipSB
    {
        public static StringBuilder equipunequipsb = new StringBuilder();
    }
    //base equipment properties
    public interface iEquipment
    {
        string type { get; set; } //the type of the item: Ring. Helmet, chest, ect
        string name { get; set; } //The displayed name
        string element { get; set; } //the element of the item, if one: fire, wind, darkness, light, ect
        string weight { get; set; }//How much the weapon weighs
        int current { get; set; }//How many of the wepaon you have
        int max { get; set; }//The max ammount that can be held at one time

        string attribute1 { get; set; }//String representing a attribute ie: Strength, Magic, etc
        string attribute2 { get; set; }
        string attribute3 { get; set; }
        string attribute4 { get; set; }

        int attribute1b { get; set; }//Number value to match the string value and what bonus to give the string values attribute
        int attribute2b { get; set; }
        int attribute3b { get; set; }
        int attribute4b { get; set; }

        int cost { get; set; } // the cost to the characters equipment inventory when equipping the item
    }
}

