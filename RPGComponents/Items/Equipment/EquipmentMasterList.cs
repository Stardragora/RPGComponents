using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public static class Equipment//Contains the master equipment class
    {
        public static Dictionary<string, GenericEquipment> iEquipmentMasterList = new Dictionary<string, GenericEquipment>();//A dictionary containing a string key and a equipment object value

        public static void populateMasterList()
        {
            //EMPTY
            iEquipmentMasterList.Add("Empty", new GenericEquipment("", "", "", "", 0, "", "", "", "", 0, 0, 0, 0, 0, 0));

            //HEAD PIECES
            iEquipmentMasterList.Add("Iron Helmet", new GenericEquipment("HELMET", "Iron Helmet", "NON", "HVY", 1, "DEF", "MDEF", "NON", "NON", 10, 5, 0, 0, 0, 99));

            //CHEST PIECES
            iEquipmentMasterList.Add("Iron Breastplate", new GenericEquipment("CHEST", "Iron Breastplate", "NON", "HVY", 1, "DEF", "MDEF", "NON", "NON", 10, 5, 0, 0, 0, 99));

            //RING ACCESSORIES
            iEquipmentMasterList.Add("Gob Ring", new GenericEquipment("RING", "Gob Ring", "NON", "ACC", 1, "STR", "NON", "NON", "NON", 15, 0, 0, 0, 0, 99));
            iEquipmentMasterList.Add("Iron Ring", new GenericEquipment("RING", "Iron Ring", "NON", "ACC", 1, "STR", "DEF", "NON", "NON", 10, 5, 0, 0, 0, 99));
        }
    }
}
