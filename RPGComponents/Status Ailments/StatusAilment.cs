using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public interface StatusAilment//Interface that all status ailments are based off of
    {
        iCharacter affectedCharacter { get; set; }//The affected iCharacterObject
        
        void statusCalculations();//performs the status calculations for the status
    }
}
