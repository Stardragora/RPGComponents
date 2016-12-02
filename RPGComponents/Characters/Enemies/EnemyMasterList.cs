using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGComponents
{
    public class EnemyMasterList
    {
        //Dictionary that contains string key references to specified enemy classes.
        public Dictionary<string, Enemy> enemyList = new Dictionary<string, Enemy>();

        public void populateEnemyList()//Adds the enemies to the enemy master list
        {
            enemyList.Add("Goblin Grunt", new Goblin());
        }
    }
}
