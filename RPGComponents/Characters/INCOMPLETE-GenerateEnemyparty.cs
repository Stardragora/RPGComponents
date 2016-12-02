using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPGComponents
{
    public static class GenerateEnemyparty
    {
        public static bool enemyPartyCreated = false;

        static Random RNG = new Random();

        static EnemyMasterList enemyMasterList = new EnemyMasterList();
        public static List<Enemy> enemyPartyList = new List<Enemy>();

        static int enemyCount;



        public static void GenerateEnemyParty()
        {
            int maxEnemy = enemyMasterList.enemyList.Count;
            enemyCount = RNG.Next(0, 2);
            enemyPartyList.Clear();
            for (int i = 0; i <= enemyCount; i++)
            {
                var serializedObj = JsonConvert.SerializeObject(forestEnemies[RNG.Next(maxEnemy)]);
                var newEnemy = JsonConvert.DeserializeObject<Enemy>(serializedObj);
                currentEnemy.Add(newEnemy);
            }

            enemyPartyCreated = true;
        }
    }
}
