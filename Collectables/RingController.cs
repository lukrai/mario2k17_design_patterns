using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class RingController : CollectibleController
    {
        public RingController(CollectibleUnit unit) : base(unit)
        {
            
        }

        public override void SecondMethod()
        {
            collectibleUnit.setRotationSpeed();
        }
    }
}