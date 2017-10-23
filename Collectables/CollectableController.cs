using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public abstract class CollectibleController
    {
        protected CollectibleUnit collectibleUnit = null;

        public CollectibleController(CollectibleUnit unit)
        {
            collectibleUnit = unit;
        }

        public void first()
        {
            //collectibleUnit.
        }
    }
}