using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Deagle : Gun
    {
        public Deagle()
        {
            
        }
        public override string ShowDescription()
        {
            return "Deagle";
        }

        public override string Shoot()
        {
            return "Deagle shooting";
        }
    }   
}