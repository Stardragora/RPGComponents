using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    static class UseItems//Class that contains methods for using items in game
    {
        public static void potionUse(string type)//The method caled by potion type items when used
        {
            switch (type)//and based on the type of potion the item is it will perform differently
            {
                case "HHEALING":
                    break;
                case "MHEALING":
                    break;
                default:
                    break;
            }
        }

        public static void restoreUse(string type)//The method called by the restore type items when used
        {
            switch (type)//and based on the ailment restored it will perform differently
            {
                case "POISON":
                    break;
                case "PARALYZE":
                    break;
                default:
                    break;
            }
        }
    }
}
