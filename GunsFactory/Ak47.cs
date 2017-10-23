using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Ak47 : Gun
    {
        public Ak47()
        {
            
        }
        public override string ShowDescription()
        {
            return "Ak47";
        }

        public override string Shoot()
        {
            return "Ak47 shooting";
        }

    }  
}