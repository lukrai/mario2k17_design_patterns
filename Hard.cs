﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Strategy pattern
    class Hard : EnemyDifficulty
    {
        public override void addDifficulty()
        {
            Console.WriteLine("Called enemy with hard difficulty");
        }
    }
}
