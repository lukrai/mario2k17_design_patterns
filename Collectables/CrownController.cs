using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class CrownController : CollectibleController
    {
        public CrownController(CollectibleUnit unit) : base(unit)
        {
            
        }

        public override void SecondMethod()
        {
            collectibleUnit.setRotationSpeed();
        }
    }
}