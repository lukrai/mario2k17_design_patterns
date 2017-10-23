using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Turtle : IEnemyAttacker
    {
        public void Fire()
        {
            Console.WriteLine("Turtle spits flames");
        }

        public void Move()
        {
            Console.WriteLine("Turtle slowly moves");
        }
    }
}