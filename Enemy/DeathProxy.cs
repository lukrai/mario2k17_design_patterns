using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Strategy pattern
    class DeathProxy : IDeath
    {
        private Death realDeath;
        public void ShowDeath()
        {
            if (realDeath == null)
            {
                realDeath = new Death();
            }
        
            realDeath.ShowDeath();
        }
    }
}
