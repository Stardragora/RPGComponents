using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Cleric : Job
    {
        public string equipType //Sets the type of equipment the character can use
        {
            get { return equipType; }
            private set { equipType = "CLOTHE"; }
        }
        public Cleric()//Initializes the cleric job
        {
            this.hpArray[0] = 0;
            this.hpArray[1] += 7;

            this.mpArray[0] = 0;
            this.mpArray[1] += 13;

            this.atkArray[0] = 0;
            this.atkArray[1] += 8;

            this.magArray[0] = 0;
            this.magArray[1] += 12;

            this.strArray[0] = 0;
            this.strArray[1] += 7;

            this.inteArray[0] = 0;
            this.inteArray[1] += 13;

            this.defArray[0] = 0;
            this.defArray[1] += 7;

            this.mdefArray[0] = 0;
            this.mdefArray[1] += 13;

            this.agiArray[0] = 0;
            this.agiArray[1] += 5;

            this.luckArray[0] = 0;
            this.luckArray[1] += 15;

            this.jobName = "Cleric";
            this.jobDescription = "The warrior is well versed at physical combat prefering up close and personal attitude. Weak to magic attacks";

            this.levelUpDictionary.Add("hp", hpArray);
            this.levelUpDictionary.Add("mp", mpArray);
            this.levelUpDictionary.Add("atk", atkArray);
            this.levelUpDictionary.Add("mag", magArray);
            this.levelUpDictionary.Add("str", strArray);
            this.levelUpDictionary.Add("inte", inteArray);
            this.levelUpDictionary.Add("def", defArray);
            this.levelUpDictionary.Add("mdef", mdefArray);
            this.levelUpDictionary.Add("agi", agiArray);
            this.levelUpDictionary.Add("luck", luckArray);

            //PROBLEM SPOT
            jobsAbilities = Abilities.clericAbilities;

            this.jobWeapon = new Mace();
        }
    }
}
