using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class RealMysteryBox : MysteryBox
    {
        public RealMysteryBox(int id)
        {
            this.Id = id;
        }

        public override int getId()
        {
            return Id;
        }

        public override bool isNull()
        {
            return false;
        }
    }
}
