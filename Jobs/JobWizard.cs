﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class Wizard : Job
    {
        public string equipType//The type of equipment that can be equipped by the job
        {
            get { return equipType; }
            private set { equipType = "CLOTHE"; }
        }

        public Wizard()//Initialises the Wizard job
        {
            this.hpArray[0] = 0;
            this.hpArray[1] += 10;

            this.mpArray[0] = 0;
            this.mpArray[1] += 10;

            this.atkArray[0] = 0;
            this.atkArray[1] += 10;

            this.magArray[0] = 0;
            this.magArray[1] += 10;

            this.strArray[0] = 0;
            this.strArray[1] += 10;

            this.inteArray[0] = 0;
            this.inteArray[1] += 10;

            this.defArray[0] = 0;
            this.defArray[1] += 10;

            this.mdefArray[0] = 0;
            this.mdefArray[1] += 10;

            this.agiArray[0] = 0;
            this.agiArray[1] += 10;

            this.luckArray[0] = 0;
            this.luckArray[1] += 10;

            this.hpArray[0] = 0;
            this.hpArray[1] += 10;

            this.jobName = "Wizard";
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
            jobsAbilities = Abilities.wizardAbilities;

            this.jobWeapon = new Staff();
        }
    }
}
