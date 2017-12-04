using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Strategy pattern
    class Enemy
    {
        private String name;
        private int damage;
        private int hitPoints;
        private EnemyDifficulty _enemyDifficulty;

        private IEnemyAttacker enemyAttacker = null;

        public Enemy(EnemyDifficulty difficulty)
        {
            this._enemyDifficulty = difficulty;
        }

        public void setEnemy()
        {
            _enemyDifficulty.addDifficulty();
        }

        public void setEnemyAttacker(IEnemyAttacker attacker)
        {
            enemyAttacker = attacker;
        }

        public void showEnemyAttacker()
        {
            enemyAttacker.Fire();
            enemyAttacker.Move();
        }

        public void showEnemyDeath()
        {
            DeathProxy deathProxy = new DeathProxy();
            deathProxy.ShowDeath();
        }


    }
}
