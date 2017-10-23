using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Crown : CollectibleUnit
    {
        public Crown(int value) : base(value)
        {

        }

        public override void setRotationSpeed()
        {
            setBakcwardsRotation();
        }

        private void setBakcwardsRotation()
        {
            Console.WriteLine("Crown Backwards rotation");
        }
    }
}