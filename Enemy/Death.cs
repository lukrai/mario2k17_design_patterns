using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Strategy pattern
    class Death : IDeath
    {
        public void ShowDeath()
        {
            Console.WriteLine("Enemy died magnificently");
        }
    }
}
