using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class AngryFlower : IEnemyAttacker
    {
        public void Fire()
        {
            Console.WriteLine("Flower shoots flames");
        }

        public void Move()
        {
            Console.WriteLine("Flower slowly moves");
        }
    }
}