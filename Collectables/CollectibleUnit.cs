using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public abstract class CollectibleUnit
    {
        private int value = 0;
        //private int rotationSpeed = 0;
        public CollectibleUnit(int newValue)
        {
            value = newValue;
        }

        public void setValue(int newValue)
        {
            value = newValue;
            Console.WriteLine("Unit value: " + value);
        }

        public abstract void setRotationSpeed();



    }
}