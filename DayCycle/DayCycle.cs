using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    abstract class DayCycle
    {
        protected DayCycle successor;
        public void setNextChain(DayCycle successor)
        {
            this.successor = successor;
        }
        public abstract void showDayTime(int time);
    }
}
