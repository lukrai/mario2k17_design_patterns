using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class NullMsteryBox : MysteryBox
    {
       

        public override int getId()
        {
            return -1;
        }

        public override bool isNull()
        {
            return true;
        }
    }
}
