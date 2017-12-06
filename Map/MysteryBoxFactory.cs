using Mario2k17.Map.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class MysteryBoxFactory
    {
        public int[] ids = { 0, 1, 2, 3, 4 };

        IdRepository newID = new IdRepository();

        public MysteryBox GetBox()
        {
            int id = newID.GetITerator().next();
            for (int i = 0; i < ids.Length; i++)
            {
                if (ids[i] == id)
                {
                    return new RealMysteryBox(id);
                }
            }

            return new NullMsteryBox();
        }
    }
}
