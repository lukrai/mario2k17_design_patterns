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

        public void show() { }

        public Enemy(EnemyDifficulty difficulty)
        {
            this._enemyDifficulty = difficulty;
        }

        public void setEnemy()
        {
            _enemyDifficulty.addDifficulty();
        }
    }
}
