using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class Morning : DayCycle
    {
        public override void showDayTime(int time)
        {
            if (time >= 6 && time < 12)
            {
                Console.WriteLine("It's Morning now!");
            }
            else if (successor != null)
            {
                successor.showDayTime(time);
            }
        }

    }
}
