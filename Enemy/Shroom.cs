using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Shroom : IEnemyAttacker
    {
        public void Fire()
        {
            Console.WriteLine("Shroom spits flames");
        }

        public void Move()
        {
            Console.WriteLine("Shroom slowly moves");
        }
    }
}