using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    class Night : DayCycle
    {
        public override void showDayTime(int time)
        {
            if (time >= 0 && time < 6)
            {
                Console.WriteLine("It's Night now!");
            }
            else if (successor != null)
            {
                successor.showDayTime(time);
            }
        }
    }
}
