using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map.Iterator
{
    class IdRepository : IContainer
    {
        public static int[] ids = { 0, 1, 2, 3, 4 };
        IdIterator idIterator = new IdIterator();
        public new Iterator GetITerator()
        {
           
            return idIterator;
        }

        class IdIterator : Iterator
        {

            int index = 0;

            public bool hasNext()
            {
                if (index < ids.Length)
                {
                    return true;
                }
                return false;
        }

            public int next()
            {
                if(this.hasNext())
                {
                    return ids[index++];
                }
                return -5;
            }
        }
    }
}
