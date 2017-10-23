using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    //Strategy pattern
    public abstract class Gun
    {
        public Gun()
        {

        }

        public abstract string ShowDescription();

        public abstract string Shoot();
    }
        
}
