using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class BossAdapter : IEnemyAttacker
    {
        private Boss boss = null;

        public BossAdapter(Boss newBoss)
        {
            boss = newBoss;
        }

        public void Fire()
        {
            boss.Blast();
        }

        public void Move()
        {
            boss.Jump();
        }
    }
}