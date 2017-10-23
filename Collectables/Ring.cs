using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Ring : CollectibleUnit
    {
        public Ring(int value) : base(value)
        {

        }

        public override void setRotationSpeed()
        {
            Console.WriteLine("Rotation speed is increasing" );
        }
    }
}