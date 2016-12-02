using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class Items//Contains all the item objects in the game
    {
        public static Dictionary<string, iItem> iItemMasterList = new Dictionary<string, iItem>();//Contains a string key and a item object value

        public static void populateMasterList()
        {
            iItemMasterList.Add("Potion", new Potion("Potion", "HHEALING", 30, 1, 0, 99));
            iItemMasterList.Add("Antidote", new Antitode("Antidote", "POISON", 100, 1, 0, 99));
            iItemMasterList.Add("Stimulant", new Antitode("Stimulant", "PARALYZE", 100, 1, 0, 99));
            iItemMasterList.Add("Ether", new Potion("Ether", "MHEALING", 30, 1, 0, 99));             
        }
    }
}
